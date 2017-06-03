namespace TOAW_OOB_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBoxEmphasis = new System.Windows.Forms.ComboBox();
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.comboBoxSupportScope = new System.Windows.Forms.ComboBox();
            this.labelEmphasis = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelSupportScope = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxReadiness = new System.Windows.Forms.TextBox();
            this.labelReadiness = new System.Windows.Forms.Label();
            this.textBoxSupply = new System.Windows.Forms.TextBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.textBoxProficiency = new System.Windows.Forms.TextBox();
            this.labelProficiency = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.buttonAddFormation = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.Name = "treeView";
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            resources.ApplyResources(this.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            resources.ApplyResources(this.CloseToolStripMenuItem, "CloseToolStripMenuItem");
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBoxEmphasis);
            this.panel.Controls.Add(this.comboBoxOrders);
            this.panel.Controls.Add(this.comboBoxSupportScope);
            this.panel.Controls.Add(this.labelEmphasis);
            this.panel.Controls.Add(this.labelOrders);
            this.panel.Controls.Add(this.labelSupportScope);
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Controls.Add(this.textBoxY);
            this.panel.Controls.Add(this.textBoxX);
            this.panel.Controls.Add(this.labelY);
            this.panel.Controls.Add(this.labelX);
            this.panel.Controls.Add(this.textBoxReadiness);
            this.panel.Controls.Add(this.labelReadiness);
            this.panel.Controls.Add(this.textBoxSupply);
            this.panel.Controls.Add(this.labelSupply);
            this.panel.Controls.Add(this.textBoxProficiency);
            this.panel.Controls.Add(this.labelProficiency);
            this.panel.Controls.Add(this.textBoxName);
            this.panel.Controls.Add(this.labelName);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // comboBoxEmphasis
            // 
            this.comboBoxEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxEmphasis, "comboBoxEmphasis");
            this.comboBoxEmphasis.FormattingEnabled = true;
            this.comboBoxEmphasis.Items.AddRange(new object[] {
            resources.GetString("comboBoxEmphasis.Items"),
            resources.GetString("comboBoxEmphasis.Items1"),
            resources.GetString("comboBoxEmphasis.Items2"),
            resources.GetString("comboBoxEmphasis.Items3")});
            this.comboBoxEmphasis.Name = "comboBoxEmphasis";
            this.comboBoxEmphasis.TextChanged += new System.EventHandler(this.ComboBoxEmphasis_LostFocus);
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxOrders, "comboBoxOrders");
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Items.AddRange(new object[] {
            resources.GetString("comboBoxOrders.Items"),
            resources.GetString("comboBoxOrders.Items1"),
            resources.GetString("comboBoxOrders.Items2"),
            resources.GetString("comboBoxOrders.Items3"),
            resources.GetString("comboBoxOrders.Items4"),
            resources.GetString("comboBoxOrders.Items5")});
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.TextChanged += new System.EventHandler(this.ComboBoxOrders_LostFocus);
            // 
            // comboBoxSupportScope
            // 
            this.comboBoxSupportScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxSupportScope, "comboBoxSupportScope");
            this.comboBoxSupportScope.FormattingEnabled = true;
            this.comboBoxSupportScope.Items.AddRange(new object[] {
            resources.GetString("comboBoxSupportScope.Items"),
            resources.GetString("comboBoxSupportScope.Items1"),
            resources.GetString("comboBoxSupportScope.Items2"),
            resources.GetString("comboBoxSupportScope.Items3"),
            resources.GetString("comboBoxSupportScope.Items4")});
            this.comboBoxSupportScope.Name = "comboBoxSupportScope";
            this.comboBoxSupportScope.TextChanged += new System.EventHandler(this.ComboBoxSupportScope_LostFocus);
            // 
            // labelEmphasis
            // 
            resources.ApplyResources(this.labelEmphasis, "labelEmphasis");
            this.labelEmphasis.Name = "labelEmphasis";
            // 
            // labelOrders
            // 
            resources.ApplyResources(this.labelOrders, "labelOrders");
            this.labelOrders.Name = "labelOrders";
            // 
            // labelSupportScope
            // 
            resources.ApplyResources(this.labelSupportScope, "labelSupportScope");
            this.labelSupportScope.Name = "labelSupportScope";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipment,
            this.Number,
            this.Max,
            this.Damage});
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 30;
            // 
            // Equipment
            // 
            resources.ApplyResources(this.Equipment, "Equipment");
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            // 
            // Number
            // 
            resources.ApplyResources(this.Number, "Number");
            this.Number.Name = "Number";
            // 
            // Max
            // 
            resources.ApplyResources(this.Max, "Max");
            this.Max.Name = "Max";
            // 
            // Damage
            // 
            resources.ApplyResources(this.Damage, "Damage");
            this.Damage.Name = "Damage";
            // 
            // textBoxY
            // 
            resources.ApplyResources(this.textBoxY, "textBoxY");
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.LostFocus += new System.EventHandler(this.textBoxY_LostFocus);
            // 
            // textBoxX
            // 
            resources.ApplyResources(this.textBoxX, "textBoxX");
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.LostFocus += new System.EventHandler(this.textBoxX_LostFocus);
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            // 
            // textBoxReadiness
            // 
            resources.ApplyResources(this.textBoxReadiness, "textBoxReadiness");
            this.textBoxReadiness.Name = "textBoxReadiness";
            this.textBoxReadiness.LostFocus += new System.EventHandler(this.textBoxReadiness_LostFocus);
            // 
            // labelReadiness
            // 
            resources.ApplyResources(this.labelReadiness, "labelReadiness");
            this.labelReadiness.Name = "labelReadiness";
            // 
            // textBoxSupply
            // 
            resources.ApplyResources(this.textBoxSupply, "textBoxSupply");
            this.textBoxSupply.Name = "textBoxSupply";
            this.textBoxSupply.LostFocus += new System.EventHandler(this.textBoxSupply_LostFocus);
            // 
            // labelSupply
            // 
            resources.ApplyResources(this.labelSupply, "labelSupply");
            this.labelSupply.Name = "labelSupply";
            // 
            // textBoxProficiency
            // 
            resources.ApplyResources(this.textBoxProficiency, "textBoxProficiency");
            this.textBoxProficiency.Name = "textBoxProficiency";
            this.textBoxProficiency.LostFocus += new System.EventHandler(this.textBoxProficiency_LostFocus);
            // 
            // labelProficiency
            // 
            resources.ApplyResources(this.labelProficiency, "labelProficiency");
            this.labelProficiency.Name = "labelProficiency";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.LostFocus += new System.EventHandler(this.textBoxName_LostFocus);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            resources.ApplyResources(this.DeleteToolStripMenuItem, "DeleteToolStripMenuItem");
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // buttonAddUnit
            // 
            resources.ApplyResources(this.buttonAddUnit, "buttonAddUnit");
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            this.buttonAddUnit.Click += new System.EventHandler(this.buttonAddUnit_Click);
            // 
            // buttonAddFormation
            // 
            resources.ApplyResources(this.buttonAddFormation, "buttonAddFormation");
            this.buttonAddFormation.Name = "buttonAddFormation";
            this.buttonAddFormation.UseVisualStyleBackColor = true;
            this.buttonAddFormation.Click += new System.EventHandler(this.buttonAddFormation_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddFormation);
            this.Controls.Add(this.buttonAddUnit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSupply;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.TextBox textBoxProficiency;
        private System.Windows.Forms.Label labelProficiency;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxReadiness;
        private System.Windows.Forms.Label labelReadiness;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Damage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.Button buttonAddFormation;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelSupportScope;
        private System.Windows.Forms.Label labelEmphasis;
        private System.Windows.Forms.ComboBox comboBoxEmphasis;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.ComboBox comboBoxSupportScope;
    }
}

