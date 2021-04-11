using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanMiner
{
    public class XML
    {
        public List<Plan> Plans;
    }
    public class Plan
    {
        [XmlAttribute("lable")]
        public string lable;
        public string Triggering;
        public string Context;
        public List<BodyLiteral> PlanBody;
    }
    public class BodyLiteral
    {
        [XmlAttribute("Type")]
        public string Type;
        public string Name;
        public string Parameters;
    }
}
