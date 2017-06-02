using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TOAW_OOB_Editor
{
    internal static class Common
    {
        public static string path;
        public static XmlDocument doc;
        public static XmlNode oob;
        public static XmlNode currentNode;

        public static void ReadInGamFile(string filename, TreeView tv)
        {
            doc = new XmlDocument();
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
            doc.Save(path);
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
                dgv.LostFocus += new EventHandler(Dgv_LostFocus);
            }
        }

        private static void Dgv_LostFocus(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                XmlElement equipment = (XmlElement)(from XmlNode node in currentNode.ChildNodes
                                                    where ((XmlElement)node).GetAttribute("NAME") == row.Cells[0].Value.ToString()
                                                    select node).ToArray()[0];
                equipment.SetAttribute("NUMBER", row.Cells[1].Value.ToString());
                equipment.SetAttribute("MAX", row.Cells[2].Value.ToString());
                equipment.SetAttribute("DAMAGE", row.Cells[3].Value.ToString());
            }
        }
    }
}