using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmYuanGongXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuanGongXX));
            this.lblxh = new Gizmox.WebGUI.Forms.Label();
            this.lbljgid = new Gizmox.WebGUI.Forms.Label();
            this.txtFax = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.txtEmail = new Gizmox.WebGUI.Forms.TextBox();
            this.lblxm = new Gizmox.WebGUI.Forms.Label();
            this.txtXm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWx = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQQ = new Gizmox.WebGUI.Forms.TextBox();
            this.txtOtel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.lblxb = new Gizmox.WebGUI.Forms.Label();
            this.lblgw = new Gizmox.WebGUI.Forms.Label();
            this.lblfax = new Gizmox.WebGUI.Forms.Label();
            this.lblotel = new Gizmox.WebGUI.Forms.Label();
            this.lblmtel = new Gizmox.WebGUI.Forms.Label();
            this.cmbZt = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXl = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbGw = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXb = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbRole = new Gizmox.WebGUI.Forms.ComboBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.lblemail = new Gizmox.WebGUI.Forms.Label();
            this.lblzt = new Gizmox.WebGUI.Forms.Label();
            this.lblroleid = new Gizmox.WebGUI.Forms.Label();
            this.lblwx = new Gizmox.WebGUI.Forms.Label();
            this.lblQQ = new Gizmox.WebGUI.Forms.Label();
            this.lblrzrq = new Gizmox.WebGUI.Forms.Label();
            this.lbllzrq = new Gizmox.WebGUI.Forms.Label();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.dtpRzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.lblxl = new Gizmox.WebGUI.Forms.Label();
            this.dtpLzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.txtMTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.btnPassword = new Gizmox.WebGUI.Forms.Button();
            this.dSjckja2 = new DLTVWGPT.Datasets.DSjckja();
            this.cmbJgTree = new DLTLib.Controls.TreeViewComboBox.TreeViewComboBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSjckja2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxh
            // 
            this.lblxh.AutoSize = true;
            this.lblxh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxh.Location = new System.Drawing.Point(50, 51);
            this.lblxh.Name = "lblxh";
            this.lblxh.Size = new System.Drawing.Size(29, 12);
            this.lblxh.TabIndex = 0;
            this.lblxh.Text = "序号";
            // 
            // lbljgid
            // 
            this.lbljgid.AutoSize = true;
            this.lbljgid.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbljgid.Location = new System.Drawing.Point(32, 80);
            this.lbljgid.Name = "lbljgid";
            this.lbljgid.Size = new System.Drawing.Size(29, 12);
            this.lbljgid.TabIndex = 1;
            this.lbljgid.Text = "机构(*)";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFax.Location = new System.Drawing.Point(376, 130);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(147, 20);
            this.txtFax.TabIndex = 13;
            // 
            // txtXh
            // 
            this.txtXh.Enabled = false;
            this.txtXh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXh.Location = new System.Drawing.Point(93, 49);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(398, 341);
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
            this.btnClose.Location = new System.Drawing.Point(517, 341);
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
            this.label3.Location = new System.Drawing.Point(62, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "id";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(376, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lblxm
            // 
            this.lblxm.AutoSize = true;
            this.lblxm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxm.Location = new System.Drawing.Point(38, 104);
            this.lblxm.Name = "lblxm";
            this.lblxm.Size = new System.Drawing.Size(41, 12);
            this.lblxm.TabIndex = 0;
            this.lblxm.Text = "姓名()";
            // 
            // txtXm
            // 
            this.txtXm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXm.Location = new System.Drawing.Point(93, 101);
            this.txtXm.Name = "txtXm";
            this.txtXm.Size = new System.Drawing.Size(100, 20);
            this.txtXm.TabIndex = 3;
            // 
            // txtWx
            // 
            this.txtWx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWx.Location = new System.Drawing.Point(376, 218);
            this.txtWx.Name = "txtWx";
            this.txtWx.Size = new System.Drawing.Size(147, 20);
            this.txtWx.TabIndex = 16;
            // 
            // txtQQ
            // 
            this.txtQQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQQ.Location = new System.Drawing.Point(376, 190);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(146, 20);
            this.txtQQ.TabIndex = 15;
            // 
            // txtOtel
            // 
            this.txtOtel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOtel.Location = new System.Drawing.Point(377, 77);
            this.txtOtel.Name = "txtOtel";
            this.txtOtel.Size = new System.Drawing.Size(146, 20);
            this.txtOtel.TabIndex = 11;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginName.Location = new System.Drawing.Point(93, 130);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(100, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // lblxb
            // 
            this.lblxb.AutoSize = true;
            this.lblxb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxb.Location = new System.Drawing.Point(50, 193);
            this.lblxb.Name = "lblxb";
            this.lblxb.Size = new System.Drawing.Size(29, 12);
            this.lblxb.TabIndex = 0;
            this.lblxb.Text = "性别";
            // 
            // lblgw
            // 
            this.lblgw.AutoSize = true;
            this.lblgw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgw.Location = new System.Drawing.Point(50, 248);
            this.lblgw.Name = "lblgw";
            this.lblgw.Size = new System.Drawing.Size(29, 12);
            this.lblgw.TabIndex = 0;
            this.lblgw.Text = "岗位";
            // 
            // lblfax
            // 
            this.lblfax.AutoSize = true;
            this.lblfax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfax.Location = new System.Drawing.Point(319, 133);
            this.lblfax.Name = "lblfax";
            this.lblfax.Size = new System.Drawing.Size(29, 12);
            this.lblfax.TabIndex = 0;
            this.lblfax.Text = "Fax";
            // 
            // lblotel
            // 
            this.lblotel.AutoSize = true;
            this.lblotel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblotel.Location = new System.Drawing.Point(319, 80);
            this.lblotel.Name = "lblotel";
            this.lblotel.Size = new System.Drawing.Size(53, 12);
            this.lblotel.TabIndex = 0;
            this.lblotel.Text = "市话";
            // 
            // lblmtel
            // 
            this.lblmtel.AutoSize = true;
            this.lblmtel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmtel.Location = new System.Drawing.Point(319, 104);
            this.lblmtel.Name = "lblmtel";
            this.lblmtel.Size = new System.Drawing.Size(29, 12);
            this.lblmtel.TabIndex = 0;
            this.lblmtel.Text = "手机";
            // 
            // cmbZt
            // 
            this.cmbZt.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.FormattingEnabled = true;
            this.cmbZt.Items.AddRange(new object[] {
            "在岗",
            "离职"});
            this.cmbZt.Location = new System.Drawing.Point(376, 48);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(95, 20);
            this.cmbZt.TabIndex = 10;
            this.cmbZt.Text = "在岗";
            // 
            // cmbXl
            // 
            this.cmbXl.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXl.FormattingEnabled = true;
            this.cmbXl.Items.AddRange(new object[] {
            "中专",
            "大专",
            "博士"});
            this.cmbXl.Location = new System.Drawing.Point(93, 278);
            this.cmbXl.Name = "cmbXl";
            this.cmbXl.Size = new System.Drawing.Size(101, 20);
            this.cmbXl.TabIndex = 9;
            this.cmbXl.Text = "大专";
            // 
            // cmbGw
            // 
            this.cmbGw.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbGw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGw.FormattingEnabled = true;
            this.cmbGw.Items.AddRange(new object[] {
            "员工",
            "职员"});
            this.cmbGw.Location = new System.Drawing.Point(93, 245);
            this.cmbGw.Name = "cmbGw";
            this.cmbGw.Size = new System.Drawing.Size(101, 20);
            this.cmbGw.TabIndex = 8;
            this.cmbGw.Text = "员工";
            // 
            // cmbXb
            // 
            this.cmbXb.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXb.FormattingEnabled = true;
            this.cmbXb.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbXb.Location = new System.Drawing.Point(93, 190);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.Size = new System.Drawing.Size(100, 20);
            this.cmbXb.TabIndex = 6;
            this.cmbXb.Text = "男";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "研发"});
            this.cmbRole.Location = new System.Drawing.Point(93, 218);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(101, 20);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.Text = "研发";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(92, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 12);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblemail.Location = new System.Drawing.Point(313, 162);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(29, 12);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "email";
            // 
            // lblzt
            // 
            this.lblzt.AutoSize = true;
            this.lblzt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblzt.Location = new System.Drawing.Point(319, 51);
            this.lblzt.Name = "lblzt";
            this.lblzt.Size = new System.Drawing.Size(53, 12);
            this.lblzt.TabIndex = 1;
            this.lblzt.Text = "状态";
            // 
            // lblroleid
            // 
            this.lblroleid.AutoSize = true;
            this.lblroleid.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroleid.Location = new System.Drawing.Point(32, 221);
            this.lblroleid.Name = "lblroleid";
            this.lblroleid.Size = new System.Drawing.Size(29, 12);
            this.lblroleid.TabIndex = 1;
            this.lblroleid.Text = "角色(*)";
            // 
            // lblwx
            // 
            this.lblwx.AutoSize = true;
            this.lblwx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwx.Location = new System.Drawing.Point(307, 221);
            this.lblwx.Name = "lblwx";
            this.lblwx.Size = new System.Drawing.Size(41, 12);
            this.lblwx.TabIndex = 1;
            this.lblwx.Text = "微信号";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQQ.Location = new System.Drawing.Point(319, 193);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(29, 12);
            this.lblQQ.TabIndex = 1;
            this.lblQQ.Text = "QQ号";
            // 
            // lblrzrq
            // 
            this.lblrzrq.AutoSize = true;
            this.lblrzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblrzrq.Location = new System.Drawing.Point(295, 248);
            this.lblrzrq.Name = "lblrzrq";
            this.lblrzrq.Size = new System.Drawing.Size(53, 12);
            this.lblrzrq.TabIndex = 1;
            this.lblrzrq.Text = "入职时间";
            // 
            // lbllzrq
            // 
            this.lbllzrq.AutoSize = true;
            this.lbllzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbllzrq.Location = new System.Drawing.Point(295, 281);
            this.lbllzrq.Name = "lbllzrq";
            this.lbllzrq.Size = new System.Drawing.Size(53, 12);
            this.lbllzrq.TabIndex = 1;
            this.lbllzrq.Text = "离职时间";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkActive.Location = new System.Drawing.Point(93, 321);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "活动";
            // 
            // dtpRzrq
            // 
            this.dtpRzrq.CustomFormat = "";
            this.dtpRzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpRzrq.Location = new System.Drawing.Point(377, 242);
            this.dtpRzrq.Name = "dtpRzrq";
            this.dtpRzrq.Size = new System.Drawing.Size(146, 21);
            this.dtpRzrq.TabIndex = 17;
            // 
            // lblxl
            // 
            this.lblxl.AutoSize = true;
            this.lblxl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxl.Location = new System.Drawing.Point(50, 281);
            this.lblxl.Name = "lblxl";
            this.lblxl.Size = new System.Drawing.Size(29, 12);
            this.lblxl.TabIndex = 1;
            this.lblxl.Text = "学历";
            // 
            // dtpLzrq
            // 
            this.dtpLzrq.CustomFormat = "";
            this.dtpLzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpLzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpLzrq.Location = new System.Drawing.Point(376, 275);
            this.dtpLzrq.Name = "dtpLzrq";
            this.dtpLzrq.Size = new System.Drawing.Size(147, 21);
            this.dtpLzrq.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "账户()";
            // 
            // txtMTel
            // 
            this.txtMTel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMTel.Location = new System.Drawing.Point(377, 101);
            this.txtMTel.Name = "txtMTel";
            this.txtMTel.Size = new System.Drawing.Size(146, 20);
            this.txtMTel.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(93, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPassword.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnPassword.Image"));
            this.btnPassword.Location = new System.Drawing.Point(5, 159);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(74, 20);
            this.btnPassword.TabIndex = 4;
            this.btnPassword.Text = "口令(*)";
            this.btnPassword.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            // 
            // dSjckja2
            // 
            this.dSjckja2.DataSetName = "DSjckja";
            this.dSjckja2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbJgTree
            // 
            this.cmbJgTree.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJgTree.FormattingEnabled = true;
            this.cmbJgTree.ImageList = this.imgLst;
            this.cmbJgTree.IsNonLeafNodeSelectable = true;
            this.cmbJgTree.Location = new System.Drawing.Point(94, 76);
            this.cmbJgTree.Name = "cmbJgTree";
            this.cmbJgTree.Size = new System.Drawing.Size(131, 21);
            this.cmbJgTree.TabIndex = 19;
            this.cmbJgTree.TreeHeight = 200;
            this.cmbJgTree.TreeWidth = 120;
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folders.Folder_yellow_open_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folders.Folder_yellow_close_16.ico");
            // 
            // FrmYuanGongXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.CloseBox = false;
            this.Controls.Add(this.cmbJgTree);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLzrq);
            this.Controls.Add(this.lblxl);
            this.Controls.Add(this.dtpRzrq);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lbllzrq);
            this.Controls.Add(this.lblrzrq);
            this.Controls.Add(this.lblQQ);
            this.Controls.Add(this.lblwx);
            this.Controls.Add(this.lblroleid);
            this.Controls.Add(this.lblzt);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbXb);
            this.Controls.Add(this.cmbGw);
            this.Controls.Add(this.cmbXl);
            this.Controls.Add(this.cmbZt);
            this.Controls.Add(this.lblmtel);
            this.Controls.Add(this.lblotel);
            this.Controls.Add(this.lblfax);
            this.Controls.Add(this.lblgw);
            this.Controls.Add(this.lblxb);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtOtel);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.txtWx);
            this.Controls.Add(this.txtXm);
            this.Controls.Add(this.lblxm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lbljgid);
            this.Controls.Add(this.lblxh);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(623, 382);
            this.Text = "员工详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.dSjckja2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblxh;
        private Label lbljgid;
        private TextBox txtFax;
        private TextBox txtXh;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private TextBox txtEmail;
        private Label lblxm;
        private TextBox txtXm;
        private TextBox txtWx;
        private TextBox txtQQ;
        private TextBox txtOtel;
        private TextBox txtLoginName;
        private Label lblxb;
        private Label lblgw;
        private Label lblfax;
        private Label lblotel;
        private Label lblmtel;
        private ComboBox cmbZt;
        private ComboBox cmbXl;
        private ComboBox cmbGw;
        private ComboBox cmbXb;
        private ComboBox cmbRole;
        private Label lblId;
        private Label lblemail;
        private Label lblzt;
        private Label lblroleid;
        private Label lblwx;
        private Label lblQQ;
        private Label lblrzrq;
        private Label lbllzrq;
        private CheckBox chkActive;
        private DateTimePicker dtpRzrq;
        private Label lblxl;
        private DateTimePicker dtpLzrq;
        private Label label1;
        private TextBox txtMTel;
        private TextBox txtPassword;
        private Button btnPassword;
        private Datasets.DSjckja dSjckja2;
        private DLTLib.Controls.TreeViewComboBox.TreeViewComboBox cmbJgTree;
        private ImageList imgLst;
    }
}