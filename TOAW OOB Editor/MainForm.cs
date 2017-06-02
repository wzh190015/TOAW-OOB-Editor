using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Common.ReadInGamFile(filename, treeView);
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
                    }
                    break;

                case "FormationNode":
                    {
                        FormationNode fomationnode = (FormationNode)selectedNode;

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
                    }
                    break;

                case "UnitNode":
                    {
                        UnitNode unitnode = (UnitNode)selectedNode;

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
                        textBoxX.Text = unitnode.x.ToString();
                        textBoxY.Text = unitnode.y.ToString();

                        Common.LoadEquipment(unitnode.unitXmlNode, dataGridView);
                    }
                    break;

                default:
                    { }
                    break;
            }
        }
    }
}