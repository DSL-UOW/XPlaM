using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlanMiner
{
    public class ContextThread
    {
      
        public void repeatChecking(ref string output)
        {
            List<string> strlist = output.Split('&').ToList();
            for (int i = 0; i < strlist.Count; i++)
                strlist[i] = strlist[i].Trim();
            if (strlist.Contains("true"))
            {
                strlist.Remove("true");
                output = string.Join(" & ", strlist);
            }
            bool ff = false;
            for (int i = 0; i < strlist.Count; i++)
            {
                if (strlist[i] == "") continue;
                for (int j = 0; j < strlist.Count; j++)
                {
                    if (i == j || strlist[j] == "" || !strlist[j].Contains("(")) continue;
                    if (strlist[i].IndexOf(strlist[j]) > -1)
                    {
                        if (i > j) strlist[j] = "";
                        else strlist[i] = "";
                        ff = true;
                        break;
                    }
                }
            }

            if (!ff) return;
            while (true)
            {
                if (strlist.Contains("")) strlist.Remove("");
                else break;
            }
            output = string.Join(" & ", strlist);

            if (output.StartsWith("&")) output = output.Substring(1).Trim();
            if (output.EndsWith("&")) output = output.Substring(0, output.Length - 1).Trim();
            if (output.IndexOf("& &") > -1) output = output.Replace("& &", "&").Trim();
        }

        public int changeContext(string line, ref string output)
        {
            int pos = line.IndexOf("->");
            List<string> str1 = line.Substring(0, pos).Trim().Split('&').ToList();
            for (int i = 0; i < str1.Count; i++)
                str1[i] = str1[i].Trim();
            string str2 = line.Substring(pos + 2).Trim();

            List<string> outputList = output.Split('&').ToList();
            for (int i = 0; i < outputList.Count; i++)
                outputList[i] = outputList[i].Trim();

            bool ff = true;
            foreach (string st in str1)
            {
                if (!outputList.Contains(st))
                {
                    ff = false;
                    break;
                }
            }
            if (!ff) return 0;

            foreach (string st in str1)
            {
                outputList.Remove(st);
            }
            outputList.Add(str2);
            output = string.Join(" & ", outputList).Trim();
            if (output.StartsWith("&")) output = output.Substring(1).Trim();
            if (output.EndsWith("&")) output = output.Substring(0, output.Length - 1).Trim();
            if (output.IndexOf("& &") > -1) output = output.Replace("& &", "&").Trim();
            return 1;
        }

        public object getParentDict(IEnumerable<XElement> hypotheses, string filepath1, string filepath2)
        {
            var parent = new Dictionary<string, List<string>>();
            // Get the triggering of XML Plans
            var events = from Plan in XDocument.Load(filepath1).Descendants("Plan") select Plan.Element("Triggering");
            if (events == null) return null;
            Queue E = new Queue();
            foreach (var e in events)
            {
                if (E.Contains(e.Value)) continue;
                E.Enqueue(e.Value);
                //Console.WriteLine(ee.Value);
            }
            // An empty stack
            Stack stack = new Stack();
            // Re cotains a subset of Hypotheses
            foreach (var e in E)
            {
                IEnumerable<XElement> Re = hypotheses.Where(x => x.Element("Triggering").Value == (string)e);
                List<string> temp_stack = new List<string>();
                foreach (XElement p in Re) { temp_stack.Add(p.Attribute("lable").Value); }
                temp_stack.Reverse();
                foreach (string p in temp_stack) { stack.Push(p); }

                while (stack.Count > 0)
                {
                    string p = (string)stack.Pop();
                    var plan = hypotheses.Where(x => x.Attribute("lable").Value == p);
                    foreach (var BodyLiteral in plan.ElementAt(0).Elements("PlanBody").Elements("BodyLiteral"))
                    {
                        string BodyLiteral_name = BodyLiteral.Element("Name").Value;

                        // ToDo ReRe does not work probably. Please check comment below
                        if (BodyLiteral.Attribute("Type").Value.Equals("achieve"))
                        {
                            var ee = BodyLiteral.Element("Name").Value;

                            // ToDo  var ReRe =  Hypotheses.Where(x => x.Element("Triggering").Value without what is between parentheses == (string)ee); 
                            var ReRe = hypotheses.Where(x => x.Element("Triggering").Value.IndexOf((string)ee) > -1 && x.Attribute("lable").Value != p).Attributes("lable").Select(x => x.Value);
                            if (parent.ContainsKey(p))
                            {
                                foreach (var h in ReRe)
                                {
                                    if (parent[p].Contains(h)) continue;
                                    parent[p].Add(h);
                                    stack.Push(h);
                                }
                            }
                            else
                            {
                                parent.Add(p, ReRe.ToList());
                                foreach (var h in ReRe) stack.Push(h);
                            }
                        }
                    }

                }

            }
            return parent;
        }

        public void checkContext(string strtemp, ref string output)
        {
            int pos1 = output.IndexOf(strtemp);
            if (pos1 > -1)
            {
                int pos2 = output.LastIndexOf("&", pos1);
                string temp = output.Substring(pos2 + 1, pos1 - pos2).Trim();
                if (temp == "not")
                {
                    output = output.Substring(0, pos2) + $" {strtemp} " + output.Substring(pos1 + strtemp.Length);
                }
            }
            else
            {
                output = output + $" & {strtemp}";
            }

        }


        public void checkContextParent(string strtemp, ref string output)
        {
            int pos1 = output.IndexOf(strtemp);
            if (pos1 > -1)
            {
                int pos2 = output.LastIndexOf("&", pos1);
                string temp = output.Substring(pos2 + 1, pos1 - pos2).Trim();
                if (temp == "not")
                {
                    output = output.Substring(0, pos2) + $" {strtemp} " + output.Substring(pos1 + strtemp.Length);
                }
            }
            else
            {
                output += $" & {strtemp}";
            }
        }



        public string getParentContext(Dictionary<string, List<string>> parent, IEnumerable<XElement> hypotheses, string me, IEnumerable<string> plLable)
        {
            string output = "";
            if (parent.ContainsKey(me))
            {
                output += " & ";
                foreach (var p in plLable)
                {
                    if (!parent.ContainsKey(p)) continue;
                    if (!parent[p].Contains(me)) continue;
                    var pContext = hypotheses.Where(e => e.Attribute("lable").Value == p).Select(e => e.Element("Context").Value);
                    output += string.Join("& ", pContext);
                    break;
                }
            }
            return output.Substring(2).Trim();
        }


        public void getPreCondition(List<string> data, ref string output)
        {
            foreach (var d in data)
            {
                int pos1 = d.IndexOf("=");
                if (pos1 > -1)
                {
                    int pos2 = output.IndexOf(d.Substring(0, pos1));
                    if (pos2 > -1)
                    {
                        int pos3 = output.IndexOf("&", pos2 + pos1);
                        if (pos3 == -1) pos3 = output.Length;
                        output = output.Substring(0, pos2) + d + " " + output.Substring(pos3);
                        continue;
                    }
                }
                if (output.Length > 0) output = output + " & " + d;
                else output = d;
            }

        }
    }
}
