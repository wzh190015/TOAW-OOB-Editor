using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;

namespace TOAW_OOB_Editor
{
    internal enum SupportScope
    {
        [Description("NULL")]
        Null,

        [Description("Force Support")]
        ForceSupport,

        [Description("Free Support")]
        FreeSupport,

        [Description("Army Support")]
        ArmySupport,

        [Description("Internal Support")]
        InternalSupport
    }

    internal enum Orders
    {
        [Description("NULL")]
        Null,

        [Description("Defend")]
        Defend,

        [Description("Attack")]
        Attack,

        [Description("Secure")]
        Secure,

        [Description("Independent")]
        Independent,

        [Description("Static")]
        Static
    }

    internal enum Emphasis
    {
        [Description("NULL")]
        Null,

        [Description("Minimize Losses")]
        MinimizeLosses,

        [Description("Limit Losses")]
        LimitLosses,

        [Description("Ignore Losses")]
        IgnoreLosses
    }

    internal static class Common
    {
        public static string path;
        public static XmlDocument doc;
        public static XmlNode oob;
        public static XmlNode currentNode;
        public static int Force1MaxFormationID = 0;
        public static int Force1MaxUnitID = 0;
        public static int Force2MaxFormationID = 0;
        public static int Force2MaxUnitID = 0;

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
                    if (forceNode.ID == 1)
                    {
                        Force1MaxFormationID = formationNode.ID > Force1MaxFormationID ? formationNode.ID : Force1MaxFormationID;
                    }
                    else
                    {
                        Force2MaxFormationID = formationNode.ID > Force2MaxFormationID ? formationNode.ID : Force2MaxFormationID;
                    }
                    forceNode.Nodes.Add(formationNode);
                    XmlNodeList units = formation.SelectNodes("UNIT");
                    foreach (XmlNode unit in units)
                    {
                        UnitNode unitNode = new UnitNode(unit);
                        if (forceNode.ID == 1)
                        {
                            Force1MaxUnitID = unitNode.ID > Force1MaxUnitID ? unitNode.ID : Force1MaxUnitID;
                        }
                        else
                        {
                            Force2MaxUnitID = unitNode.ID > Force2MaxUnitID ? unitNode.ID : Force2MaxUnitID;
                        }
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
            Console.WriteLine(GetDescription(GetEnumName<SupportScope>("Force Support")));
        }

        /// <summary>
        /// 从枚举中获取Description
        /// 说明：
        /// 单元测试-->通过
        /// </summary>
        /// <param name="value">需要获取枚举描述的枚举</param>
        /// <returns>描述内容</returns>
        public static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        /// <summary>
        /// 将枚举转换为ArrayList
        /// 说明：
        /// 若不是枚举类型，则返回NULL
        /// 单元测试-->通过
        /// </summary>
        /// <param name="type">枚举类型</param>
        /// <returns>ArrayList</returns>
        public static T GetEnumName<T>(string description)
        {
            Type _type = typeof(T);
            foreach (FieldInfo field in _type.GetFields())
            {
                DescriptionAttribute[] _curDesc = field.GetDescriptAttr();
                if (_curDesc != null && _curDesc.Length > 0)
                {
                    if (_curDesc[0].Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException(string.Format("{0} 未能找到对应的枚举.", description), "Description");
        }

        /// <summary>
        /// 获取字段Description
        /// </summary>
        /// <param name="fieldInfo">FieldInfo</param>
        /// <returns>DescriptionAttribute[] </returns>
        public static DescriptionAttribute[] GetDescriptAttr(this FieldInfo fieldInfo)
        {
            if (fieldInfo != null)
            {
                return (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            }
            return null;
        }
    }
}