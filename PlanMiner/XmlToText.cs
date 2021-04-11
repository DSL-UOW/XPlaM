using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanMiner
{
    class XmlToText
    {
        public string filepath;
        public XmlToText( string filepath)
        {
            this.filepath = filepath;
        }
        public string GetText()
        {
            if (string.IsNullOrEmpty(filepath)) return "Error ";
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XML));
                XML ds;
                using (Stream reader = new FileStream(filepath, FileMode.Open))
                {
                    ds = (XML)serializer.Deserialize(reader);
                }

                string strOutput = "";
                foreach (Plan pl in ds.Plans)
                {
                    strOutput += pl.Triggering + "\r\n\t:  " + pl.Context + "\r\n\t<- ";
                    foreach (BodyLiteral blt in pl.PlanBody)
                    {
                        strOutput += blt.Name;
                        if (blt.Parameters != null)
                            strOutput += "(" + blt.Parameters + ")";
                        strOutput += ";\r\n\t   ";
                    }
                    strOutput = strOutput.Substring(0, strOutput.LastIndexOf(";")) + ".";
                    strOutput += "\r\n\r\n";
                }

                string outFile = Path.GetDirectoryName(filepath) + "\\" + Path.GetFileNameWithoutExtension(filepath) + ".txt";
                TextWriter writer = new StreamWriter(outFile);
                writer.Write(strOutput);
                writer.Close();

                return outFile;
            }
            catch (Exception ex)
            {
                return "Error " + ex.Message;
            }
        }
    }
}
