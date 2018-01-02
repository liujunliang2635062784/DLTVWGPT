using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT
{
    partial class FrmPractice
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
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.txtA = new Gizmox.WebGUI.Forms.TextBox();
            this.btnTest = new Gizmox.WebGUI.Forms.Button();
            this.tcA = new Gizmox.WebGUI.Forms.TabControl();
            this.toLst = new Gizmox.WebGUI.Forms.TabPage();
            this.lst = new Gizmox.WebGUI.Forms.ListBox();
            this.tpDgv = new Gizmox.WebGUI.Forms.TabPage();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcA)).BeginInit();
            this.tcA.SuspendLayout();
            this.toLst.SuspendLayout();
            this.tpDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Linen;
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.txtA);
            this.pnlTop.Controls.Add(this.btnTest);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(708, 111);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(352, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(208, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(105, 35);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "Hello";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(92, 45);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(60, 29);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "测试";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tcA
            // 
            this.tcA.Controls.Add(this.toLst);
            this.tcA.Controls.Add(this.tpDgv);
            this.tcA.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcA.Location = new System.Drawing.Point(0, 111);
            this.tcA.Name = "tcA";
            this.tcA.SelectedIndex = 0;
            this.tcA.Size = new System.Drawing.Size(708, 355);
            this.tcA.TabIndex = 1;
            // 
            // toLst
            // 
            this.toLst.Controls.Add(this.lst);
            this.toLst.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.toLst.Location = new System.Drawing.Point(4, 22);
            this.toLst.Name = "toLst";
            this.toLst.Size = new System.Drawing.Size(700, 329);
            this.toLst.TabIndex = 0;
            this.toLst.Text = "Lst";
            // 
            // lst
            // 
            this.lst.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lst.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.Location = new System.Drawing.Point(3, 3);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(700, 328);
            this.lst.TabIndex = 0;
            // 
            // tpDgv
            // 
            this.tpDgv.Controls.Add(this.dgv);
            this.tpDgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpDgv.Location = new System.Drawing.Point(4, 22);
            this.tpDgv.Name = "tpDgv";
            this.tpDgv.Size = new System.Drawing.Size(411, 329);
            this.tpDgv.TabIndex = 0;
            this.tpDgv.Text = "Dgv";
            // 
            // dgv
            // 
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(405, 323);
            this.dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(476, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 18);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FrmPractice
            // 
            this.Controls.Add(this.tcA);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(708, 466);
            this.Text = "FrmPractice";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcA)).EndInit();
            this.tcA.ResumeLayout(false);
            this.toLst.ResumeLayout(false);
            this.tpDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private TextBox txtA;
        private Button btnTest;
        private TabControl tcA;
        private TabPage toLst;
        private ListBox lst;
        private TabPage tpDgv;
        private DataGridView dgv;
        private Button btnClear;
        private GroupBox groupBox1;
    }
}