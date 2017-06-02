using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TOAW_OOB_Editor
{
    internal class FormationNode : TreeNode
    {
        public XmlNode formationXmlNode;
        public string name;
        public int proficiency;
        public int supply;

        public FormationNode(XmlNode node) : base(((XmlElement)node).GetAttribute("NAME"))
        {
            formationXmlNode = node;
            XmlElement element = (XmlElement)node;
            name = element.GetAttribute("NAME");
            proficiency = int.Parse(element.GetAttribute("PROFICIENCY"));
            supply = int.Parse(element.GetAttribute("SUPPLY"));
        }
    }
}