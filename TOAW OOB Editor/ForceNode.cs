﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TOAW_OOB_Editor
{
    internal class ForceNode : TreeNode
    {
        public XmlNode forceXmlNode;
        public int ID;
        public string name;
        public int proficiency;
        public int supply;

        public ForceNode(XmlNode node) : base(((XmlElement)node).GetAttribute("NAME"))
        {
            forceXmlNode = node;
            XmlElement element = (XmlElement)node;
            ID = int.Parse(element.GetAttribute("ID"));
            name = element.GetAttribute("NAME");
            proficiency = int.Parse(element.GetAttribute("proficiency"));
            supply = int.Parse(element.GetAttribute("supply"));
        }
    }
}