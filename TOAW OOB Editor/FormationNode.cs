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
        public int ID;
        public int proficiency;
        public int supply;
        public SupportScope supportScope;
        public Orders orders;
        public Emphasis emphasis;

        public FormationNode(XmlNode node) : base(((XmlElement)node).GetAttribute("NAME"))
        {
            formationXmlNode = node;
            XmlElement element = (XmlElement)node;
            ID = int.Parse(element.GetAttribute("ID"));
            name = element.GetAttribute("NAME");
            proficiency = int.Parse(element.GetAttribute("PROFICIENCY"));
            supply = int.Parse(element.GetAttribute("SUPPLY"));
            supportScope = Common.GetEnumName<SupportScope>(element.GetAttribute("SUPPORTSCOPE"));
            orders = Common.GetEnumName<Orders>(element.GetAttribute("ORDERS"));
            emphasis = Common.GetEnumName<Emphasis>(element.GetAttribute("EMPHASIS"));
        }
    }
}