using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlanMiner
{
    class AbductivePlanRecognition
    {
        public string filepath1, filepath2;
        public AbductivePlanRecognition(string filepath1, string filepath2)
        {
            this.filepath1 = filepath1;
            this.filepath2 = filepath2;
        }
        public string GegerateFile()
        {
            bool flag = false;
            List<string> Data = new List<string>();
            foreach (string line in File.ReadLines(filepath2))
            {
                string[] column = line.Split(',');
                if (column.Length < 2) return "";
                if (!flag)
                {
                    flag = true;
                    continue;
                }
                if (Data.Contains(column[1])) continue;
                Data.Add(column[1]);
            }

            var Hypotheses = XDocument.Load(filepath1).Descendants("Plan");
            if (Hypotheses == null) return "";
            var explain = new Dictionary<string, List<string>>();
            var parent = new Dictionary<string, List<string>>();
            var events = from Plan in XDocument.Load(filepath1).Descendants("Plan") select Plan.Element("Triggering");

            if (events == null) return "";
            Queue E = new Queue();
            foreach (var e in events)
            {
                if (E.Contains(e.Value)) continue;
                E.Enqueue(e.Value);
            }
            Stack stack = new Stack();

            foreach (string d in Data)
            {
                foreach (var e in E)
                {  
                    IEnumerable<XElement> Re = Hypotheses.Where(x => x.Element("Triggering").Value == (string)e);
                    List<string> temp_stack = new List<string>();
                    foreach (XElement p in Re) { temp_stack.Add(p.Attribute("lable").Value); }
                    temp_stack.Reverse();
                    foreach (string p in temp_stack) { stack.Push(p); }
                    while (stack.Count > 0)
                    {   
                        string p = (string)stack.Pop();
                        var plan = Hypotheses.Where(x => x.Attribute("lable").Value == p);
                        
                        foreach (var BodyLiteral in plan.ElementAt(0).Elements("PlanBody").Elements("BodyLiteral"))
                        {  
                            string BodyLiteral_name = BodyLiteral.Element("Name").Value;
                            if (BodyLiteral.Attribute("Type").Value.Equals("action") && d.IndexOf(BodyLiteral_name) > -1)
                            {   
                                if (explain.ContainsKey(d))
                                {   
                                    if (!explain[d].Contains(p))
                                        explain[d].Add(p);
                                }
                                else
                                {   
                                    explain.Add(d, new List<string>() { p });
                                }
                                continue;
                            }

                            if (BodyLiteral.Attribute("Type").Value.Equals("achieve"))
                            {   
                                var ee = BodyLiteral.Element("Name").Value;

                                var ReRe = Hypotheses.Where(x => x.Element("Triggering").Value.IndexOf((string)ee) > -1 && x.Attribute("lable").Value != p).Attributes("lable").Select(x => x.Value);
                                if (parent.ContainsKey(p))
                                {
                                    foreach (var h in ReRe)
                                    {   
                                        if (parent[p].Contains(h)) continue;
                                        parent[p].Add(h);
                                        stack.Push(h);

                                        if (parent.ContainsKey(h))
                                        {
                                            foreach (var hh in parent[h])
                                                if (!explain[d].Contains(hh)) explain[d].Add(hh);
                                        }

                                    }
                                }
                                else
                                {   // push sub-plans to stack
                                    parent.Add(p, ReRe.ToList());
                                    foreach (var h in ReRe) stack.Push(h);
                                }
                            }
                        }

                    }

                }

            }

            string outPut = "/* Abducted Plans */ \n";
            string strExplain = "";
            List<string> checkExplain = new List<string>();
            foreach (var pair in explain)
            {
                string observation = pair.Key;
                List<string> hypoth = pair.Value;
                strExplain += "explain(";
                foreach (string p in hypoth)
                {
                    strExplain += p;
                    if (checkExplain.Contains(p)) continue;
                    checkExplain.Add(p);
                    outPut += $"@{p} {PlanToText(p, Hypotheses)}\n\n";
                }
                strExplain += $") = {observation}\n";
            }

            outPut += "\n/* Required Plans */\n";
            foreach (var relation in parent)
            {
                string father = relation.Key;
                List<string> child = relation.Value;

                if (!checkExplain.Contains(father))
                {
                    checkExplain.Add(father);
                    outPut += $"@{father} {PlanToText(father, Hypotheses)}\n\n";
                }
                //Console.Write("Parent(" + father + ") = " + "explain(");
                foreach (string p in child)
                {
                    //Console.Write(p + " ");
                    if (checkExplain.Contains(p)) continue;
                    checkExplain.Add(p);
                    outPut += $"@{p} {PlanToText(p, Hypotheses)}\n\n";
                }
                //Console.WriteLine(")");
            }

            outPut += $"\n/* Model of Abduction */\n\n{strExplain}\n\n/* Abducted Selection Functions */";

            Queue goal_events = new Queue();
            foreach (var p in parent)
            {
                string father = p.Key;
                bool ff = parent.Where(e => e.Value.Contains(father) && e.Key != father).Select(e => e.Key).Any();
                if (!ff)
                {
                    string trig = Hypotheses.Where(e => e.Attribute("lable").Value.Equals(father)).Select(e => e.Element("Triggering").Value).Single();
                    if (!goal_events.Contains(trig)) goal_events.Enqueue(trig);
                }
            }

            Regex rx = new Regex(@"[a-zA-Z]+$");

            string strOut = "\n\n/**********************************************\n *\n * This code has been generated by XPlaM tool.\n * Copy XPlaM.Class into your Jason project as a java file.\n * Add Agent_name agentClass XPlaM; to your mas2j file.\n *\n **********************************************/ \n";
            string strOut1 = "", strOut2 = "", strOut3 = "", strOut4 = "";
            strOut += "import jason.asSemantics.*;\nimport jason.asSyntax.*;\nimport java.util.*;\n\npublic class XPlaM extends Agent {\n";
            int t = 0;
            string strOut21 = "", strOut22 = "", strOut41 ="";
            foreach (string trig in goal_events)
            {
                t++;
                string trig_name = trig.Substring(0, trig.IndexOf("("));
                MatchCollection str_trigname = rx.Matches(trig_name);
                strOut1 += $"\n\tprivate Trigger t{t} = Trigger.parseTrigger(\"{trig}\");";
                strOut2 += $"\n\t\t\tboolean e{t} = e.getTrigger().equals(Trigger.parseTrigger(\"{trig}\"));";
                //strOut2 += $"\n\t\t\tif (un.unifies({str_trigname[0]}, e.getTrigger())) {{ ie.remove(); return e; break;}}";
                if (t == 1) strOut21 += "\n\t\t\tif (";
                else strOut21 += "\n\t\t\telse if (";
                for (int i=0; i<goal_events.Count;i++)
                {
                    if (i > 0) strOut21 += " && ";
                    if (t == i+1) strOut21 += $"e{i+1}";
                    else strOut21 += $"!e{i+1}";
                }
                strOut21 += ")  { i.remove(); return e;}";
                strOut22 += $"\n\t\t\t\t\tif (im.getPlan().getTrigger().getLiteral().getFunctor().equals(\"{trig}\")) {{ \n\t\t\t\t\t\ti.remove();\n\t\t\t\t\t\treturn e;\n\t\t\t\t\t}}";
                strOut4 += $"\n\t\t\t\tboolean i{t} = cit.hasTrigger(t{t}, new Unifier());";
                if (t == 1) strOut41 += "\n\t\t\t\tif (";
                else strOut41 += "\n\t\t\t\telse if (";
                for (int i = 0; i < goal_events.Count; i++)
                {
                    if (i > 0) strOut41 += " && ";
                    if (t == i + 1) strOut41 += $"i{i + 1}";
                    else strOut41 += $"!i{i + 1}";
                }
                strOut41 += ")  {return cit;}";
            }
            strOut += strOut1;
            //strOut += "\n\n\tprivate Unifier un = new Unifier();\n";
            strOut += "\n\t@Override\n\tpublic Event selectEvent(Queue<Event> events) {";
            strOut += "\n\t\tIterator<Event> i = events.iterator();";
            strOut += "\n\t\twhile (i.hasNext()) {\n\t\t\tEvent e = i.next();";
            strOut += strOut2 +  strOut21;
            strOut += "\n\n\t\t\tif (e.getIntention() != null) {\n\t\t\t\tfor (IntendedMeans im: e.getIntention()) {";
            strOut += "\n" + strOut22 + "\n\t\t\t\t}\n\t\t\t}";
            strOut += "\n\t\t}\n\t\treturn super.selectEvent(events);\n\t}\n";


            strOut += "\n\t/**\n\t * Change the order in which plans are written in the agent code as follows:";
            //strOut += "\n\t * plan from explain.Value, then Options(plan)";

            List<string> checkPlan = new List<string>();
            foreach (var p in Hypotheses)
            {
                if (checkPlan.Contains(p.Attribute("lable").Value)) continue;
                string trig_context = p.Element("Triggering").Value + p.Element("Context").Value;
                var plans = Hypotheses.Where(e => (e.Element("Triggering").Value + e.Element("Context").Value).Equals(trig_context)).Select(e => e.Attribute("lable").Value);
                string strTemp = "";
                if (plans.ToList().Count > 1)
                {
                    foreach (var pl in plans)
                    {
                        checkPlan.Add(pl);
                        if (strTemp.Length > 0) strTemp += $" \"then\" {pl}";
                        else strTemp += pl;
                    }
                    checkPlan.Add(p.Attribute("lable").Value);
                    strOut3 += $"\n\t * {strTemp}";
                }
            }

            strOut += strOut3;
            strOut += "\n\t */\n\n\t@Override\n\tpublic Option selectOption(List<Option> options) {";
            strOut += "\n\t\tif (options != null && !options.isEmpty()) {";
            strOut += "\n\t\t\treturn options.remove(0);";
            strOut += "\n\t\t} else {\n\t\t\treturn null;\n\t\t}\n\t}\n";

            strOut += "\n\n\t@Override\n\tpublic Intention selectIntention(Queue<Intention> intentions) {\n\t\tif (intentions.size() > 1) {";
            strOut += "\n\t\t\tIterator <Intention> i = intentions.iterator();\n\t\t\twhile (i.hasNext()) {\n\t\t\t\tIntention cit = i.next();";
            strOut += strOut4 + "\n" + strOut41 + "\n\t\t\t\ti.remove();}\n\t\t}\n\t\treturn super.selectIntention(intentions);\n\t}\n}";

            outPut += strOut;

            string outFile = Path.GetDirectoryName(filepath2) + "\\" + Path.GetFileNameWithoutExtension(filepath2) + " (Abducted BDI Design)" + ".txt";
            TextWriter writer = new StreamWriter(outFile);
            writer.Write(outPut);
            writer.Close();

            return outFile;
        }

        public string PlanToText(string p, IEnumerable<XElement> Hypotheses)
        {
            string strOutput = "";
            var plan = Hypotheses.Where(x => x.Attribute("lable").Value == p).Single();

            strOutput += $"{plan.Element("Triggering").Value}\r\n\t:  {plan.Element("Context").Value}\r\n\t<- ";
            foreach (XElement blt in plan.Element("PlanBody").Elements("BodyLiteral"))
            {
                strOutput += blt.Element("Name").Value;
                if (blt.Element("Parameters") != null)
                    strOutput += $"({blt.Element("Parameters").Value})";
                strOutput += ";\r\n\t   ";
            }
            strOutput = strOutput.Substring(0, strOutput.LastIndexOf(";")) + ".";
            return strOutput;
        }
    }
}

