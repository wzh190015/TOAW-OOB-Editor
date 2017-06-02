using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TOAW_OOB_Editor
{
    internal class UnitNode : TreeNode
    {
        public XmlNode unitXmlNode;
        public string name;
        public int proficiency;
        public int supply;
        public int readiness;
        public int x;
        public int y;

        public UnitNode(XmlNode node) : base(((XmlElement)node).GetAttribute("NAME"))
        {
            unitXmlNode = node;
            XmlElement element = (XmlElement)node;
            name = element.GetAttribute("NAME");
            proficiency = int.Parse(element.GetAttribute("PROFICIENCY"));
            supply = int.Parse(element.GetAttribute("SUPPLY"));
            readiness = int.Parse(element.GetAttribute("READINESS"));
            if (string.IsNullOrEmpty(element.GetAttribute("X")))
            {
                x = 0;
            }
            else
            {
                x = int.Parse(element.GetAttribute("X"));
            }
            if (string.IsNullOrEmpty(element.GetAttribute("Y")))
            {
                y = 0;
            }
            else
            {
                y = int.Parse(element.GetAttribute("Y"));
            }
        }
    }
}