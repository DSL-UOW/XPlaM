using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanMiner
{
    class TextToXml
    {
        public string filepath;
        public TextToXml( string filepath)
        {
            this.filepath = filepath;
        }
        public string GetXml()
        {
            if (string.IsNullOrEmpty(filepath)) return "";
            var file = File.OpenText(filepath);

            XML ds = new XML();
            XmlSerializer serializer = new XmlSerializer(typeof(XML));

            ds.Plans = new List<Plan>();

            string line, content = "";
            int pos0 = -1, label = 0;
            bool flag = false;
            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();
                if (line == "") continue;
                content += line;
                if (line[line.Length - 1] == '.')
                {
                    string temp = content;
                    content = ""; label++;
                    pos0 = temp.IndexOf(":");

                    if (pos0 == -1) return "";

                    Plan pl = new Plan();
                    pl.lable = "p" + label.ToString();
                    pl.Triggering = temp.Substring(0, pos0).Trim();

                    temp = temp.Substring(pos0 + 1).Trim();
                    pos0 = temp.IndexOf("<-");
                    if (pos0 == -1) return "";

                    pl.Context = temp.Substring(0, pos0).Trim();
                    temp = temp.Substring(pos0 + 2).Trim();

                    pl.PlanBody = new List<BodyLiteral>();
                    while (temp.Length > 0)
                    {
                        BodyLiteral pb = new BodyLiteral();
                        pos0 = temp.IndexOf(";");
                        if (pos0 == -1)
                        {
                            string strTemp = temp.Substring(0, temp.Length - 1).Trim();
                            temp = "";
                            pb = checkString(strTemp);
                        }
                        else
                        {
                            string strTemp = temp.Substring(0, pos0).Trim();
                            temp = temp.Substring(pos0 + 1).Trim();
                            pb = checkString(strTemp);
                        }
                        pl.PlanBody.Add(pb);
                    }
                    ds.Plans.Add(pl);
                    flag = true;
                }
            }
            if (flag == false) return "";

            string outFile = Path.GetDirectoryName(filepath) + "\\" + Path.GetFileNameWithoutExtension(filepath) + " (XPlaM)" + ".xml";
            TextWriter writer = new StreamWriter(outFile);
            serializer.Serialize(writer, ds);
            writer.Close();
            return outFile;
        }

        private BodyLiteral checkString(string temp)
        {
            BodyLiteral blt = new BodyLiteral();

            string strOutput = "\t\t\t<BodyLiteral ", strTemp = temp;
            if (temp.Substring(0, 2) == "-+")
            {
                strOutput += "Type=\"delAddBel\">";
                blt.Type = "delAddBel";
            }
            else if (temp.Substring(0, 2) == "!!")
            {
                strOutput += "Type=\"achieveNF\">";
                blt.Type = "achieveNF";
            }
            else if (temp[0] == '.')
            {
                strOutput += "Type=\"internalAction\">";
                blt.Type = "internalAction";
            }
            else if (temp[0] == '!')
            {
                strOutput += "Type=\"achieve\">";
                blt.Type = "achieve";
            }
            else if (temp[0] == '?')
            {
                strOutput += "Type=\"test\">";
                blt.Type = "test";
            }
            else if (temp[0] == '+')
            {
                strOutput += "Type=\"addBel\">";
                blt.Type = "addBel";
            }
            else if (temp[0] == '-')
            {
                strOutput += "Type=\"delBel\">";
                blt.Type = "delBel";
            }
            else
            {
                if (strTemp.Equals("true"))
                {
                    strOutput += "Type=\"none\">";
                    blt.Type = "none";
                }
                else
                {
                    strOutput += "Type=\"action\">";
                    blt.Type = "action";
                }
            }

            int pos = strTemp.IndexOf("(");
            if (pos == -1)
            {
                strOutput += Environment.NewLine + "\t\t\t\t<Name>" + strTemp + "</Name>\r\n\t\t\t</BodyLiteral>";
                blt.Name = strTemp;
            }
            else
            {
                strOutput += Environment.NewLine + "\t\t\t\t<Name>" + strTemp.Substring(0, pos) + "</Name>";
                strOutput += Environment.NewLine + "\t\t\t\t<Parameters>" + strTemp.Substring(pos + 1, strTemp.Length - 2 - pos) + "</Parameters>\r\n\t\t\t</BodyLiteral>";
                blt.Name = strTemp.Substring(0, pos);
                blt.Parameters = strTemp.Substring(pos + 1, strTemp.Length - 2 - pos);
            }
            return blt;
        }

    }
}
