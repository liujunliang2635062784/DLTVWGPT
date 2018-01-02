using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhmxXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhmxXX));
            this.lblxh = new Gizmox.WebGUI.Forms.Label();
            this.txtDw = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.txtDj = new Gizmox.WebGUI.Forms.TextBox();
            this.lblxm = new Gizmox.WebGUI.Forms.Label();
            this.txtPm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtSl = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.lblfax = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.lblemail = new Gizmox.WebGUI.Forms.Label();
            this.lblQQ = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.dsJxc1 = new JXC.Datasets.DSJxc();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.lblJe = new Gizmox.WebGUI.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxh
            // 
            this.lblxh.AutoSize = true;
            this.lblxh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxh.Location = new System.Drawing.Point(32, 52);
            this.lblxh.Name = "lblxh";
            this.lblxh.Size = new System.Drawing.Size(29, 12);
            this.lblxh.TabIndex = 0;
            this.lblxh.Text = "序号(*)";
            // 
            // txtDw
            // 
            this.txtDw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDw.Location = new System.Drawing.Point(314, 49);
            this.txtDw.Name = "txtDw";
            this.txtDw.Size = new System.Drawing.Size(147, 20);
            this.txtDw.TabIndex = 13;
            // 
            // txtXh
            // 
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
            this.btnSave.Location = new System.Drawing.Point(368, 207);
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
            this.btnClose.Location = new System.Drawing.Point(482, 207);
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
            // txtDj
            // 
            this.txtDj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDj.Location = new System.Drawing.Point(314, 80);
            this.txtDj.Name = "txtDj";
            this.txtDj.Size = new System.Drawing.Size(147, 20);
            this.txtDj.TabIndex = 14;
            this.txtDj.Leave += new System.EventHandler(this.txtDj_Leave);
            // 
            // lblxm
            // 
            this.lblxm.AutoSize = true;
            this.lblxm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblxm.Location = new System.Drawing.Point(32, 88);
            this.lblxm.Name = "lblxm";
            this.lblxm.Size = new System.Drawing.Size(41, 12);
            this.lblxm.TabIndex = 0;
            this.lblxm.Text = "品名(*)";
            // 
            // txtPm
            // 
            this.txtPm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPm.Location = new System.Drawing.Point(93, 85);
            this.txtPm.Name = "txtPm";
            this.txtPm.Size = new System.Drawing.Size(100, 20);
            this.txtPm.TabIndex = 3;
            // 
            // txtSl
            // 
            this.txtSl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSl.Location = new System.Drawing.Point(314, 119);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(147, 20);
            this.txtSl.TabIndex = 15;
            this.txtSl.Leave += new System.EventHandler(this.txtDj_Leave);
            // 
            // txtBm
            // 
            this.txtBm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBm.Location = new System.Drawing.Point(93, 119);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(100, 20);
            this.txtBm.TabIndex = 4;
            // 
            // lblfax
            // 
            this.lblfax.AutoSize = true;
            this.lblfax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfax.Location = new System.Drawing.Point(250, 52);
            this.lblfax.Name = "lblfax";
            this.lblfax.Size = new System.Drawing.Size(29, 12);
            this.lblfax.TabIndex = 0;
            this.lblfax.Text = "单位(*)";
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
            this.lblemail.Location = new System.Drawing.Point(250, 88);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(29, 12);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "单价(*)";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQQ.Location = new System.Drawing.Point(250, 122);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(29, 12);
            this.lblQQ.TabIndex = 1;
            this.lblQQ.Text = "数量(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "编码(*)";
            // 
            // dsJxc1
            // 
            this.dsJxc1.DataSetName = "DSJxc";
            this.dsJxc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "金额";
            // 
            // lblJe
            // 
            this.lblJe.AutoSize = true;
            this.lblJe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJe.Location = new System.Drawing.Point(312, 159);
            this.lblJe.Name = "lblJe";
            this.lblJe.Size = new System.Drawing.Size(17, 12);
            this.lblJe.TabIndex = 1;
            this.lblJe.Text = "je";
            // 
            // FrmJhmxXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.CloseBox = false;
            this.Controls.Add(this.lblJe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQQ);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblfax);
            this.Controls.Add(this.txtBm);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtPm);
            this.Controls.Add(this.lblxm);
            this.Controls.Add(this.txtDj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.txtDw);
            this.Controls.Add(this.lblxh);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(623, 382);
            this.Text = "进货明细详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblxh;
        private TextBox txtDw;
        private TextBox txtXh;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private TextBox txtDj;
        private Label lblxm;
        private TextBox txtPm;
        private TextBox txtSl;
        private TextBox txtBm;
        private Label lblfax;
        private Label lblId;
        private Label lblemail;
        private Label lblQQ;
        private Label label1;
        private Datasets.DSJxc dsJxc1;
        private ImageList imgLst;
        private Label label2;
        private Label lblJe;
    }
}