using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmMKGL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMKGL));
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.mnuTrV = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewbrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.dSjckja1 = new DLTVWGPT.Datasets.DSjckja();
            this.tfuncsTableAdapter1 = new DLTVWGPT.Datasets.DSjckjaTableAdapters.tfuncsTableAdapter();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtBz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.lblld = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.grpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSjckja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.trV);
            this.grpLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpLeft.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLeft.Location = new System.Drawing.Point(10, 10);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(260, 460);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "模块树";
            // 
            // trV
            // 
            this.trV.ContextMenuStrip = this.mnuTrV;
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.ImageKey = "Folders.Folder_yellow_close_16.ico";
            this.trV.ImageList = this.imgLst;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.SelectedImageKey = "Folders.Folder_yellow_open_16.ico";
            this.trV.SelectOnRightClick = true;
            this.trV.Size = new System.Drawing.Size(254, 440);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // mnuTrV
            // 
            this.mnuTrV.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuTrV.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuTrV.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuTrV.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuTrV.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewbrother,
            this.mnuNewChild,
            this.mnuDel});
            this.mnuTrV.Name = "mnuTrV";
            this.mnuTrV.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewbrother
            // 
            this.mnuNewbrother.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewbrother.Image"));
            this.mnuNewbrother.Name = "mnuNewbrother";
            this.mnuNewbrother.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewbrother.Size = new System.Drawing.Size(147, 20);
            this.mnuNewbrother.Text = "新增同级模块";
            this.mnuNewbrother.Click += new System.EventHandler(this.mnuNewbrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "mnuNewChild";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级模块";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前模块";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(0, 0);
            this.imgLst.Images.SetKeyName(0, "Folders.Folder_yellow_close_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folders.Folder_yellow_open_16.ico");
            // 
            // dSjckja1
            // 
            this.dSjckja1.DataSetName = "DSjckja";
            this.dSjckja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tfuncsTableAdapter1
            // 
            this.tfuncsTableAdapter1.ClearBeforeFill = true;
            // 
            // bds
            // 
            this.bds.AllowNew = true;
            this.bds.DataMember = "tfuncs";
            this.bds.DataSource = this.dSjckja1;
            // 
            // grpMain
            // 
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(270, 10);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(320, 460);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "模块信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCancel.Image"));
            this.btnCancel.Location = new System.Drawing.Point(231, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 22);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(140, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Checked", this.bds, "active", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(170, 298);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "活动";
            // 
            // txtBz
            // 
            this.txtBz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtBz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBz.Location = new System.Drawing.Point(109, 226);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(171, 26);
            this.txtBz.TabIndex = 5;
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJb.Enabled = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJb.Location = new System.Drawing.Point(109, 194);
            this.txtJb.Name = "txtJb";
            this.txtJb.Size = new System.Drawing.Size(109, 26);
            this.txtJb.TabIndex = 4;
            // 
            // txtBm
            // 
            this.txtBm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bm", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtBm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBm.Location = new System.Drawing.Point(109, 156);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(109, 27);
            this.txtBm.TabIndex = 3;
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMc.Location = new System.Drawing.Point(109, 123);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(109, 23);
            this.txtMc.TabIndex = 2;
            // 
            // txtXh
            // 
            this.txtXh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtXh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXh.Location = new System.Drawing.Point(109, 85);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(109, 25);
            this.txtXh.TabIndex = 1;
            // 
            // lblld
            // 
            this.lblld.AutoSize = true;
            this.lblld.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.lblld.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblld.ForeColor = System.Drawing.Color.DarkRed;
            this.lblld.Location = new System.Drawing.Point(107, 58);
            this.lblld.Name = "lblld";
            this.lblld.Size = new System.Drawing.Size(35, 13);
            this.lblld.TabIndex = 6;
            this.lblld.Text = "lblld";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "编号（*）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称（*）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号（*）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtBz);
            this.groupBox1.Controls.Add(this.txtJb);
            this.groupBox1.Controls.Add(this.txtBm);
            this.groupBox1.Controls.Add(this.txtMc);
            this.groupBox1.Controls.Add(this.txtXh);
            this.groupBox1.Controls.Add(this.lblld);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(270, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模块信息";
            // 
            // FrmMKGL
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLeft);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 480);
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.FrmMKGL_Load);
            this.grpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSjckja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox grpLeft;
        private TreeView trV;
        private ImageList imgLst;
        private Datasets.DSjckja dSjckja1;
        private Datasets.DSjckjaTableAdapters.tfuncsTableAdapter tfuncsTableAdapter1;
        private BindingSource bds;
        private GroupBox grpMain;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkActive;
        private TextBox txtBz;
        private TextBox txtJb;
        private TextBox txtBm;
        private TextBox txtMc;
        private TextBox txtXh;
        private Label lblld;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private GroupBox groupBox1;
        private ContextMenuStrip mnuTrV;
        private ToolStripMenuItem mnuNewbrother;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripMenuItem mnuDel;
    }
}