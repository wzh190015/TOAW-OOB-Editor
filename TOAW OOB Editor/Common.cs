using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace TOAW_OOB_Editor
{
    internal static class Common
    {
        public static string path;
        public static XmlNode oob;

        public static void ReadInGamFile(string filename, TreeView tv)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode game = doc.SelectSingleNode("GAME");
            XmlNode oob = game.SelectSingleNode("OOB");
            Common.oob = oob;
            XmlNodeList forces = oob.SelectNodes("FORCE");
            foreach (XmlNode force in forces)
            {
                ForceNode forceNode = new ForceNode(force);
                tv.Nodes.Add(forceNode);
                XmlNodeList formations = force.SelectNodes("FORMATION");
                foreach (XmlNode formation in formations)
                {
                    FormationNode formationNode = new FormationNode(formation);
                    forceNode.Nodes.Add(formationNode);
                    XmlNodeList units = formation.SelectNodes("UNIT");
                    foreach (XmlNode unit in units)
                    {
                        UnitNode unitNode = new UnitNode(unit);
                        formationNode.Nodes.Add(unitNode);
                    }
                }
            }
        }

        public static void SaveFile(string path)
        {
            //TODO
        }

        public static void LoadEquipment(XmlNode node, DataGridView dgv)
        {
            XmlNodeList equipments = node.SelectNodes("EQUIPMENT");
            foreach (XmlNode equipment in equipments)
            {
                XmlElement ele = (XmlElement)equipment;
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = ele.GetAttribute("NAME");
                dgv.Rows[index].Cells[1].Value = ele.GetAttribute("NUMBER");
                dgv.Rows[index].Cells[2].Value = ele.GetAttribute("MAX");
                dgv.Rows[index].Cells[3].Value = ele.GetAttribute("DAMAGE");
            }
        }
    }
}