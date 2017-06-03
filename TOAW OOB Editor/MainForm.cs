using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TOAW_OOB_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "gam文件(*.gam)|";
            ofd.ShowDialog();
            string filename = ofd.FileName;
            treeView.Nodes.Clear();
            Common.ReadInGamFile(filename, treeView);
            Common.path = filename;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.SaveFile(Common.path);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "gam文件(*.gam)|";
            sfd.ShowDialog();
            string filename = sfd.FileName;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            switch (selectedNode.GetType().Name)
            {
                case "ForceNode":
                    {
                        ForceNode forcenode = (ForceNode)selectedNode;
                        Common.currentNode = forcenode.forceXmlNode;

                        textBoxName.Enabled = true;
                        textBoxName.Text = "";
                        textBoxProficiency.Enabled = true;
                        textBoxProficiency.Text = "";
                        textBoxSupply.Enabled = true;
                        textBoxSupply.Text = "";
                        textBoxReadiness.Enabled = false;
                        textBoxReadiness.Text = "";
                        textBoxX.Enabled = false;
                        textBoxX.Text = "";
                        textBoxY.Enabled = false;
                        textBoxY.Text = "";
                        dataGridView.Enabled = false;
                        dataGridView.Rows.Clear();

                        textBoxName.Text = forcenode.name;
                        textBoxProficiency.Text = forcenode.proficiency.ToString();
                        textBoxSupply.Text = forcenode.supply.ToString();

                        buttonAddFormation.Enabled = true;
                        buttonAddUnit.Enabled = false;
                    }
                    break;

                case "FormationNode":
                    {
                        FormationNode fomationnode = (FormationNode)selectedNode;
                        Common.currentNode = fomationnode.formationXmlNode;

                        textBoxName.Enabled = true;
                        textBoxName.Text = "";
                        textBoxProficiency.Enabled = true;
                        textBoxProficiency.Text = "";
                        textBoxSupply.Enabled = true;
                        textBoxSupply.Text = "";
                        textBoxReadiness.Enabled = false;
                        textBoxReadiness.Text = "";
                        textBoxX.Enabled = false;
                        textBoxX.Text = "";
                        textBoxY.Enabled = false;
                        textBoxY.Text = "";
                        dataGridView.Enabled = false;
                        dataGridView.Rows.Clear();

                        textBoxName.Text = fomationnode.name;
                        textBoxProficiency.Text = fomationnode.proficiency.ToString();
                        textBoxSupply.Text = fomationnode.supply.ToString();
                        buttonAddFormation.Enabled = true;
                        buttonAddUnit.Enabled = true;
                    }
                    break;

                case "UnitNode":
                    {
                        UnitNode unitnode = (UnitNode)selectedNode;
                        Common.currentNode = unitnode.unitXmlNode;

                        textBoxName.Enabled = true;
                        textBoxName.Text = "";
                        textBoxProficiency.Enabled = true;
                        textBoxProficiency.Text = "";
                        textBoxSupply.Enabled = true;
                        textBoxSupply.Text = "";
                        textBoxReadiness.Enabled = true;
                        textBoxReadiness.Text = "";
                        textBoxX.Enabled = true;
                        textBoxX.Text = "";
                        textBoxY.Enabled = true;
                        textBoxY.Text = "";
                        dataGridView.Enabled = true;
                        dataGridView.Rows.Clear();

                        textBoxName.Text = unitnode.name;
                        textBoxProficiency.Text = unitnode.proficiency.ToString();
                        textBoxSupply.Text = unitnode.supply.ToString();
                        textBoxReadiness.Text = unitnode.readiness.ToString();
                        if (unitnode.x != -1)
                        {
                            textBoxX.Text = unitnode.x.ToString();
                        }
                        if (unitnode.y != -1)
                        {
                            textBoxY.Text = unitnode.y.ToString();
                        }
                        buttonAddFormation.Enabled = true;
                        buttonAddUnit.Enabled = true;

                        Common.LoadEquipment(unitnode.unitXmlNode, dataGridView);
                    }
                    break;

                default:
                    { }
                    break;
            }
        }

        private void textBoxY_LostFocus(object sender, EventArgs e)
        {
            XmlElement ele = ((XmlElement)Common.currentNode);
            if (string.IsNullOrEmpty(textBoxY.Text))
            {
                if (!string.IsNullOrEmpty(ele.GetAttribute("Y")))
                {
                    ele.RemoveAttribute("Y");
                }
            }
            else
            {
                ele.Attributes.Append(Common.doc.CreateAttribute("Y"));
                ele.SetAttribute("Y", textBoxY.Text);
            }
        }

        private void textBoxX_LostFocus(object sender, EventArgs e)
        {
            XmlElement ele = ((XmlElement)Common.currentNode);
            if (string.IsNullOrEmpty(textBoxY.Text))
            {
                if (!string.IsNullOrEmpty(ele.GetAttribute("X")))
                {
                    ele.RemoveAttribute("X");
                }
            }
            else
            {
                ele.Attributes.Append(Common.doc.CreateAttribute("X"));
                ele.SetAttribute("X", textBoxY.Text);
            }
        }

        private void textBoxReadiness_LostFocus(object sender, EventArgs e)
        {
            ((XmlElement)Common.currentNode).SetAttribute("READINESS", textBoxReadiness.Text);
        }

        private void textBoxSupply_LostFocus(object sender, EventArgs e)
        {
            string supply = "SUPPLY";
            if (string.IsNullOrEmpty(((XmlElement)Common.currentNode).GetAttribute("SUPPLY")))
            {
                supply = "supply";
            }
           ((XmlElement)Common.currentNode).SetAttribute(supply, textBoxSupply.Text);
        }

        private void textBoxProficiency_LostFocus(object sender, EventArgs e)
        {
            string proficiency = "PROFICIENCY";
            if (string.IsNullOrEmpty(((XmlElement)Common.currentNode).GetAttribute("PROFICIENCY")))
            {
                proficiency = "proficiency";
            }
           ((XmlElement)Common.currentNode).SetAttribute(proficiency, textBoxProficiency.Text);
        }

        private void textBoxName_LostFocus(object sender, EventArgs e)
        {
            ((XmlElement)Common.currentNode).SetAttribute("NAME", textBoxName.Text);
        }

        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode treeNode = treeView.GetNodeAt(e.Location);
                if (treeNode != null)
                {
                    treeView.SelectedNode = treeNode;
                    treeView_AfterSelect(sender, null);
                    string typename = treeNode.GetType().Name;
                    if (typename == "ForceNode")
                    {
                        Common.currentNode = ((ForceNode)treeNode).forceXmlNode;
                        return;
                    }
                    contextMenuStrip.Show(this, e.Location);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.currentNode.ParentNode.RemoveChild(Common.currentNode);
            treeView.SelectedNode.Remove();
        }

        private void buttonAddFormation_Click(object sender, EventArgs e)
        {
            ForceNode forceNode;
            switch (treeView.SelectedNode.GetType().Name)
            {
                case "ForceNode":
                    {
                        forceNode = (ForceNode)treeView.SelectedNode;
                    }
                    break;

                case "FormationNode":
                    {
                        forceNode = (ForceNode)treeView.SelectedNode.Parent;
                    }
                    break;

                case "UnitNode":
                    {
                        forceNode = (ForceNode)treeView.SelectedNode.Parent.Parent;
                    }
                    break;

                default:
                    {
                        forceNode = null;
                    }
                    break;
            }

            XmlElement newFormation = Common.doc.CreateElement("FORMATION");

            newFormation.SetAttributeNode(Common.doc.CreateAttribute("ID"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("NAME"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("PROFICIENCY"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("SUPPLY"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("SUPPORTSCOPE"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("ORDERS"));
            newFormation.SetAttributeNode(Common.doc.CreateAttribute("EMPHASIS"));
            if (forceNode.ID == 1)
            {
                newFormation.SetAttribute("ID", (++Common.Force1MaxFormationID).ToString());
            }
            else
            {
                newFormation.SetAttribute("ID", (++Common.Force2MaxFormationID).ToString());
            }
            newFormation.SetAttribute("NAME", "NewFormation");
            newFormation.SetAttribute("PROFICIENCY", "100");
            newFormation.SetAttribute("SUPPLY", "100");
            newFormation.SetAttribute("SUPPORTSCOPE", "Internal Support");
            newFormation.SetAttribute("ORDERS", "Attack");
            newFormation.SetAttribute("EMPHASIS", "Limit Losses");

            XmlElement track1 = Common.doc.CreateElement("OBJECTIVES");
            track1.SetAttributeNode(Common.doc.CreateAttribute("TRACK"));
            track1.SetAttribute("TRACK", "1");
            XmlElement track2 = Common.doc.CreateElement("OBJECTIVES");
            track2.SetAttributeNode(Common.doc.CreateAttribute("TRACK"));
            track2.SetAttribute("TRACK", "2");
            XmlElement track3 = Common.doc.CreateElement("OBJECTIVES");
            track3.SetAttributeNode(Common.doc.CreateAttribute("TRACK"));
            track3.SetAttribute("TRACK", "3");
            XmlElement track4 = Common.doc.CreateElement("OBJECTIVES");
            track4.SetAttributeNode(Common.doc.CreateAttribute("TRACK"));
            track4.SetAttribute("TRACK", "4");
            XmlElement track5 = Common.doc.CreateElement("OBJECTIVES");
            track5.SetAttributeNode(Common.doc.CreateAttribute("TRACK"));
            track5.SetAttribute("TRACK", "5");

            newFormation.AppendChild(track1);
            newFormation.AppendChild(track2);
            newFormation.AppendChild(track3);
            newFormation.AppendChild(track4);
            newFormation.AppendChild(track5);

            forceNode.forceXmlNode.AppendChild(newFormation);
            FormationNode newFormationNode = new FormationNode(newFormation);
            forceNode.Nodes.Add(newFormationNode);
            treeView.SelectedNode = newFormationNode;
            treeView_AfterSelect(sender, null);
        }

        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            FormationNode formationNode;
            switch (treeView.SelectedNode.GetType().Name)
            {
                case "FormationNode":
                    {
                        formationNode = (FormationNode)treeView.SelectedNode;
                    }
                    break;

                case "UnitNode":
                    {
                        formationNode = (FormationNode)treeView.SelectedNode.Parent;
                    }
                    break;

                default:
                    {
                        formationNode = null;
                    }
                    break;
            }

            XmlElement newUnit = Common.doc.CreateElement("UNIT");

            newUnit.SetAttributeNode(Common.doc.CreateAttribute("ID"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("NAME"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("COLOR"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("SIZE"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("EXPERIENCE"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("PROFICIENCY"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("READINESS"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("SUPPLY"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("X"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("Y"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("EMPHASIS"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("PARENT"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("STATUS"));
            newUnit.SetAttributeNode(Common.doc.CreateAttribute("REPLACEMENTPRIORITY"));

            if (((ForceNode)formationNode.Parent).ID == 1)
            {
                newUnit.SetAttribute("ID", (++Common.Force1MaxFormationID).ToString());
            }
            else
            {
                newUnit.SetAttribute("ID", (++Common.Force2MaxFormationID).ToString());
            }
            newUnit.SetAttribute("NAME", "NewFormation");
            newUnit.SetAttribute("COLOR", "55");
            newUnit.SetAttribute("SIZE", "Regiment");
            newUnit.SetAttribute("EXPERIENCE", "untried");
            newUnit.SetAttribute("PROFICIENCY", "100");
            newUnit.SetAttribute("SUPPLY", "100");
            newUnit.SetAttribute("SUPPORTSCOPE", "Internal Support");
            newUnit.SetAttribute("ORDERS", "Attack");
            newUnit.SetAttribute("EMPHASIS", "Limit Losses");
            newUnit.SetAttribute("PARENT", formationNode.ID.ToString());
            newUnit.SetAttribute("STATUS", "8");
            newUnit.SetAttribute("REPLACEMENTPRIORITY", "0");

            formationNode.formationXmlNode.AppendChild(newUnit);
            UnitNode newUnitNode = new UnitNode(newUnit);
            formationNode.Nodes.Add(newUnitNode);
            treeView.SelectedNode = newUnitNode;
            treeView_AfterSelect(sender, null);
        }
    }
}