using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhdXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhdXX));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.lblxh = new Gizmox.WebGUI.Forms.Label();
            this.lbljgid = new Gizmox.WebGUI.Forms.Label();
            this.txtJhdh = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.lblxm = new Gizmox.WebGUI.Forms.Label();
            this.txtLxr = new Gizmox.WebGUI.Forms.TextBox();
            this.txtGhsh = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.lblzt = new Gizmox.WebGUI.Forms.Label();
            this.txtLxdh = new Gizmox.WebGUI.Forms.TextBox();
            this.dsJxc = new JXC.Datasets.DSJxc();
            this.pnlBottom = new Gizmox.WebGUI.Forms.Panel();
            this.grpMaster = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.colId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colXh = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colPm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colBm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDw = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colSl = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDj = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colJhdId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpDetail = new Gizmox.WebGUI.Forms.GroupBox();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.tableAdapterManager1 = new JXC.Datasets.DSJxcTableAdapters.TableAdapterManager();
            this.tjhmxTableAdapter1 = new JXC.Datasets.DSJxcTableAdapters.tjhmxTableAdapter();
            this.bdsMX = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.lblHj = new Gizmox.WebGUI.Forms.Label();
            this.colJe = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxh
            // 
            this.lblxh.AutoSize = true;
            this.lblxh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxh.Location = new System.Drawing.Point(32, 45);
            this.lblxh.Name = "lblxh";
            this.lblxh.Size = new System.Drawing.Size(47, 12);
            this.lblxh.TabIndex = 0;
            this.lblxh.Text = "单号(*)";
            // 
            // lbljgid
            // 
            this.lbljgid.AutoSize = true;
            this.lbljgid.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbljgid.Location = new System.Drawing.Point(20, 79);
            this.lbljgid.Name = "lbljgid";
            this.lbljgid.Size = new System.Drawing.Size(59, 12);
            this.lbljgid.TabIndex = 1;
            this.lbljgid.Text = "供货商(*)";
            // 
            // txtJhdh
            // 
            this.txtJhdh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJhdh.Location = new System.Drawing.Point(82, 76);
            this.txtJhdh.Name = "txtJhdh";
            this.txtJhdh.Size = new System.Drawing.Size(124, 20);
            this.txtJhdh.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(342, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.Location = new System.Drawing.Point(465, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(62, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "id";
            // 
            // lblxm
            // 
            this.lblxm.AutoSize = true;
            this.lblxm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxm.Location = new System.Drawing.Point(232, 79);
            this.lblxm.Name = "lblxm";
            this.lblxm.Size = new System.Drawing.Size(53, 12);
            this.lblxm.TabIndex = 0;
            this.lblxm.Text = "联系电话";
            // 
            // txtLxr
            // 
            this.txtLxr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLxr.Location = new System.Drawing.Point(288, 76);
            this.txtLxr.Name = "txtLxr";
            this.txtLxr.Size = new System.Drawing.Size(100, 20);
            this.txtLxr.TabIndex = 3;
            // 
            // txtGhsh
            // 
            this.txtGhsh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGhsh.Location = new System.Drawing.Point(82, 42);
            this.txtGhsh.Name = "txtGhsh";
            this.txtGhsh.Size = new System.Drawing.Size(100, 20);
            this.txtGhsh.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(80, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 12);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblzt
            // 
            this.lblzt.AutoSize = true;
            this.lblzt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblzt.Location = new System.Drawing.Point(244, 45);
            this.lblzt.Name = "lblzt";
            this.lblzt.Size = new System.Drawing.Size(41, 12);
            this.lblzt.TabIndex = 1;
            this.lblzt.Text = "联系人";
            // 
            // txtLxdh
            // 
            this.txtLxdh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLxdh.Location = new System.Drawing.Point(288, 42);
            this.txtLxdh.Name = "txtLxdh";
            this.txtLxdh.Size = new System.Drawing.Size(100, 20);
            this.txtLxdh.TabIndex = 5;
            // 
            // dsJxc
            // 
            this.dsJxc.DataSetName = "DSJxc";
            this.dsJxc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 328);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(603, 44);
            this.pnlBottom.TabIndex = 6;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.lblHj);
            this.grpMaster.Controls.Add(this.label1);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.lblId);
            this.grpMaster.Controls.Add(this.txtLxr);
            this.grpMaster.Controls.Add(this.txtLxdh);
            this.grpMaster.Controls.Add(this.lblxm);
            this.grpMaster.Controls.Add(this.lblxh);
            this.grpMaster.Controls.Add(this.lblzt);
            this.grpMaster.Controls.Add(this.lbljgid);
            this.grpMaster.Controls.Add(this.txtGhsh);
            this.grpMaster.Controls.Add(this.txtJhdh);
            this.grpMaster.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpMaster.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMaster.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaster.Location = new System.Drawing.Point(10, 10);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(603, 107);
            this.grpMaster.TabIndex = 7;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "进货单";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.colId,
            this.colXh,
            this.colPm,
            this.colBm,
            this.colDw,
            this.colSl,
            this.colDj,
            this.colJhdId,
            this.colJe});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 69);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectOnRightClick = true;
            this.dgv.Size = new System.Drawing.Size(597, 139);
            this.dgv.TabIndex = 0;
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // colId
            // 
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colXh
            // 
            this.colXh.DefaultCellStyle = dataGridViewCellStyle3;
            this.colXh.HeaderText = "序号";
            this.colXh.Name = "colXh";
            this.colXh.ReadOnly = true;
            this.colXh.Width = 40;
            // 
            // colPm
            // 
            this.colPm.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPm.HeaderText = "品名";
            this.colPm.Name = "colPm";
            this.colPm.ReadOnly = true;
            // 
            // colBm
            // 
            this.colBm.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBm.HeaderText = "编码";
            this.colBm.Name = "colBm";
            this.colBm.ReadOnly = true;
            this.colBm.Width = 80;
            // 
            // colDw
            // 
            this.colDw.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDw.HeaderText = "单位";
            this.colDw.Name = "colDw";
            this.colDw.ReadOnly = true;
            this.colDw.Width = 40;
            // 
            // colSl
            // 
            this.colSl.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSl.HeaderText = "数量";
            this.colSl.Name = "colSl";
            this.colSl.ReadOnly = true;
            this.colSl.Width = 40;
            // 
            // colDj
            // 
            this.colDj.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDj.HeaderText = "单价";
            this.colDj.Name = "colDj";
            this.colDj.ReadOnly = true;
            this.colDj.Width = 70;
            // 
            // colJhdId
            // 
            this.colJhdId.DefaultCellStyle = dataGridViewCellStyle9;
            this.colJhdId.HeaderText = "JhdId";
            this.colJhdId.Name = "colJhdId";
            this.colJhdId.ReadOnly = true;
            this.colJhdId.Width = 50;
            // 
            // mnuDgv
            // 
            this.mnuDgv.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuDgv.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuDgv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuDgv.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuDgv.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDgv.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuDetail,
            this.mnuDel});
            this.mnuDgv.Name = "mnuDgv";
            this.mnuDgv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNew
            // 
            this.mnuNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNew.Image"));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNew.Size = new System.Drawing.Size(97, 20);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEdit.Image"));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEdit.Size = new System.Drawing.Size(97, 20);
            this.mnuEdit.Text = "编辑";
            this.mnuEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetail.Image"));
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetail.Size = new System.Drawing.Size(97, 20);
            this.mnuDetail.Text = "详细";
            this.mnuDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(97, 20);
            this.mnuDel.Text = "删除";
            this.mnuDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.dgv);
            this.grpDetail.Controls.Add(this.pnlTop);
            this.grpDetail.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpDetail.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetail.Location = new System.Drawing.Point(10, 117);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(603, 211);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "进货明细";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(597, 52);
            this.pnlTop.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(101, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(56, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "新增";
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.Location = new System.Drawing.Point(445, 11);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 30);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.Location = new System.Drawing.Point(326, 11);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(56, 30);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.Location = new System.Drawing.Point(212, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tjhdTableAdapter = null;
            this.tableAdapterManager1.tjhmxTableAdapter = this.tjhmxTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = JXC.Datasets.DSJxcTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tjhmxTableAdapter1
            // 
            this.tjhmxTableAdapter1.ClearBeforeFill = true;
            // 
            // bdsMX
            // 
            this.bdsMX.DataMember = "tjhmx";
            this.bdsMX.DataSource = this.dsJxc;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "合计";
            // 
            // lblHj
            // 
            this.lblHj.AutoSize = true;
            this.lblHj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHj.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHj.Location = new System.Drawing.Point(487, 45);
            this.lblHj.Name = "lblHj";
            this.lblHj.Size = new System.Drawing.Size(17, 12);
            this.lblHj.TabIndex = 1;
            this.lblHj.Text = "hj";
            // 
            // colJe
            // 
            this.colJe.DefaultCellStyle = dataGridViewCellStyle10;
            this.colJe.HeaderText = "金额";
            this.colJe.Name = "colJe";
            this.colJe.ReadOnly = true;
            this.colJe.Width = 80;
            // 
            // FrmJhdXX
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CloseBox = false;
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.pnlBottom);
            this.DockPadding.All = 10;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(623, 382);
            this.Text = "进货单详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblxh;
        private Label lbljgid;
        private TextBox txtJhdh;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private Label lblxm;
        private TextBox txtLxr;
        private TextBox txtGhsh;
        private Label lblId;
        private Label lblzt;
        private TextBox txtLxdh;
        private Datasets.DSJxc dsJxc;
        private Panel pnlBottom;
        private GroupBox grpMaster;
        private DataGridView dgv;
        private GroupBox grpDetail;
        private Panel pnlTop;
        private Button btnNew;
        private Button btnDel;
        private Button btnDetail;
        private Button btnEdit;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colXh;
        private DataGridViewTextBoxColumn colPm;
        private DataGridViewTextBoxColumn colBm;
        private DataGridViewTextBoxColumn colDw;
        private DataGridViewTextBoxColumn colSl;
        private DataGridViewTextBoxColumn colDj;
        private DataGridViewTextBoxColumn colJhdId;
        private Datasets.DSJxcTableAdapters.TableAdapterManager tableAdapterManager1;
        private Datasets.DSJxcTableAdapters.tjhmxTableAdapter tjhmxTableAdapter1;
        private BindingSource bdsMX;
        private Label lblHj;
        private Label label1;
        private DataGridViewTextBoxColumn colJe;
    }
}