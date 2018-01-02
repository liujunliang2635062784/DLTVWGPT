using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmJGGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJGGL));
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.mnuTrV = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewbrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.dSjckja1 = new DLTVWGPT.Datasets.DSjckja();
            this.tjigouTableAdapter1 = new DLTVWGPT.Datasets.DSjckjaTableAdapters.tjigouTableAdapter();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtDz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtYb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFzrld = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMC = new Gizmox.WebGUI.Forms.TextBox();
            this.lblld = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtProvince = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWzbz = new Gizmox.WebGUI.Forms.TextBox();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.cmbBmlx = new Gizmox.WebGUI.Forms.ComboBox();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
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
            this.grpLeft.Text = "机构树";
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
            this.mnuNewbrother.Text = "新增同级机构";
            this.mnuNewbrother.Click += new System.EventHandler(this.mnuNewbrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "mnuNewChild";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级机构";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前机构";
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
            // tjigouTableAdapter1
            // 
            this.tjigouTableAdapter1.ClearBeforeFill = true;
            // 
            // bds
            // 
            this.bds.AllowNew = true;
            this.bds.DataMember = "tjigou";
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
            this.grpMain.Text = "机构信息";
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
            this.btnCancel.Location = new System.Drawing.Point(352, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 22);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(221, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Checked", this.bds, "active", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(83, 193);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 11;
            this.chkActive.Text = "活动";
            // 
            // txtDz
            // 
            this.txtDz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtDz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDz.Location = new System.Drawing.Point(251, 109);
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(200, 20);
            this.txtDz.TabIndex = 8;
            // 
            // txtYb
            // 
            this.txtYb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "yb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtYb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYb.Location = new System.Drawing.Point(251, 134);
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(100, 20);
            this.txtYb.TabIndex = 9;
            // 
            // txtFzrld
            // 
            this.txtFzrld.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "fzrid", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtFzrld.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFzrld.Location = new System.Drawing.Point(69, 109);
            this.txtFzrld.Name = "txtFzrld";
            this.txtFzrld.Size = new System.Drawing.Size(100, 20);
            this.txtFzrld.TabIndex = 3;
            // 
            // txtJc
            // 
            this.txtJc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJc.Location = new System.Drawing.Point(69, 83);
            this.txtJc.Name = "txtJc";
            this.txtJc.Size = new System.Drawing.Size(100, 20);
            this.txtJc.TabIndex = 2;
            // 
            // txtMC
            // 
            this.txtMC.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtMC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMC.Location = new System.Drawing.Point(69, 57);
            this.txtMC.Name = "txtMC";
            this.txtMC.Size = new System.Drawing.Size(100, 20);
            this.txtMC.TabIndex = 1;
            // 
            // lblld
            // 
            this.lblld.AutoSize = true;
            this.lblld.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.lblld.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblld.ForeColor = System.Drawing.Color.DarkRed;
            this.lblld.Location = new System.Drawing.Point(67, 30);
            this.lblld.Name = "lblld";
            this.lblld.Size = new System.Drawing.Size(35, 13);
            this.lblld.TabIndex = 6;
            this.lblld.Text = "lblld";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "级别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "部门类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "负责人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "简称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJb);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtWzbz);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbBmlx);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtDz);
            this.groupBox1.Controls.Add(this.txtYb);
            this.groupBox1.Controls.Add(this.txtFzrld);
            this.groupBox1.Controls.Add(this.txtJc);
            this.groupBox1.Controls.Add(this.txtMC);
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
            this.groupBox1.Size = new System.Drawing.Size(527, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "机构信息";
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJb.Enabled = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJb.Location = new System.Drawing.Point(69, 160);
            this.txtJb.Name = "txtJb";
            this.txtJb.Size = new System.Drawing.Size(100, 20);
            this.txtJb.TabIndex = 5;
            // 
            // txtProvince
            // 
            this.txtProvince.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "province", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtProvince.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(251, 57);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "city", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtCity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(251, 83);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtWzbz
            // 
            this.txtWzbz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "wzbz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtWzbz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWzbz.Location = new System.Drawing.Point(251, 160);
            this.txtWzbz.Name = "txtWzbz";
            this.txtWzbz.Size = new System.Drawing.Size(100, 20);
            this.txtWzbz.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(210, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "邮箱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(186, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "位置标志";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(210, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "地址";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(210, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "城市";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "省份";
            // 
            // cmbBmlx
            // 
            this.cmbBmlx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("SelectedValue", this.bds, "bmlx", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.cmbBmlx.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbBmlx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBmlx.FormattingEnabled = true;
            this.cmbBmlx.Location = new System.Drawing.Point(69, 134);
            this.cmbBmlx.Name = "cmbBmlx";
            this.cmbBmlx.Size = new System.Drawing.Size(100, 20);
            this.cmbBmlx.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "备注";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "级别";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "编号（*）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "名称（*）";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "序号（*）";
            // 
            // FrmJGGL
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLeft);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(807, 480);
            this.Text = "机构管理";
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
        private Datasets.DSjckjaTableAdapters.tjigouTableAdapter tjigouTableAdapter1;
        private BindingSource bds;
        private GroupBox grpMain;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkActive;
        private TextBox txtDz;
        private TextBox txtYb;
        private TextBox txtFzrld;
        private TextBox txtJc;
        private TextBox txtMC;
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
        private Label label14;
        private Label label13;
        private ComboBox cmbBmlx;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtJb;
        private TextBox txtProvince;
        private TextBox txtCity;
        private TextBox txtWzbz;
    }
}