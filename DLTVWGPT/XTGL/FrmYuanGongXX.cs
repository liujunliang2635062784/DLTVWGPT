#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using DLTVWGPT.Datasets;
using DLTVWGPT.Datasets.DSjckjaTableAdapters;

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmYuanGongXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSjckja dsJckja1;
        private tygTableAdapter tygTableAdapter1;
        private DataGridView dgv;
        private String defaultPassword;
        private int minPwLen;
        #endregion
        public FrmYuanGongXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSjckja aDSJckja,
           tygTableAdapter atygTableAdapter1, DataGridView aDgv = null)
        {
            
            bds = aBds;
            fillCmbs();
            binding();
            NED = aNED;
            dsJckja1 = aDSJckja;
            tygTableAdapter1 = atygTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckja1.tyg);
            defaultPassword = ClsMSSQL.GetConfigStr("DefaultPassword", ClsDBCon.ConStrKj);
            minPwLen = ClsMSSQL.GetConfigInt("MinPWLen", ClsDBCon.ConStrKj);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
                DSjckja.tygRow r = (DSjckja.tygRow)((DataRowView)bds.Current).Row;
            }
            else if (NED == EnumNED.DETALL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void binding()
        {
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbJgTree.DataBindings.Clear();
            this.cmbJgTree.DataBindings.Add(new Binding("SelectedValue", this.bds, "jgid", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtXm.DataBindings.Clear();
            this.txtXm.DataBindings.Add(new Binding("Text", this.bds, "xm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLoginName.DataBindings.Clear();
            this.txtLoginName.DataBindings.Add(new Binding("Text", this.bds, "loginname", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.DataBindings.Clear();
            this.txtPassword.DataBindings.Add(new Binding("Text", this.bds, "password", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtXh.DataBindings.Clear();
            this.txtXh.DataBindings.Add(new Binding("Text", this.bds, "xh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbXb.DataBindings.Clear();
            this.cmbXb.DataBindings.Add(new Binding("SelectedValue", this.bds, "xb", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbRole.DataBindings.Clear();
            this.cmbRole.DataBindings.Add(new Binding("SelectedValue", this.bds, "roleid", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbGw.DataBindings.Clear();
            this.cmbGw.DataBindings.Add(new Binding("SelectedValue", this.bds, "gw", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbXl.DataBindings.Clear();
            this.cmbXl.DataBindings.Add(new Binding("SelectedValue", this.bds, "xl", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbZt.DataBindings.Clear();
            this.cmbZt.DataBindings.Add(new Binding("SelectedValue", this.bds, "zt", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.chkActive.DataBindings.Clear();
            this.chkActive.DataBindings.Add(new Binding("Checked", this.bds, "active", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtOtel.DataBindings.Clear();
            this.txtOtel.DataBindings.Add(new Binding("Text", this.bds, "otel", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMTel.DataBindings.Clear();
            this.txtMTel.DataBindings.Add(new Binding("Text", this.bds, "mtel", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtFax.DataBindings.Clear();
            this.txtFax.DataBindings.Add(new Binding("Text", this.bds, "fax", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtEmail.DataBindings.Clear();
            this.txtEmail.DataBindings.Add(new Binding("Text", this.bds, "email", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtQQ.DataBindings.Clear();
            this.txtQQ.DataBindings.Add(new Binding("Text", this.bds, "qq", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtWx.DataBindings.Clear();
            this.txtWx.DataBindings.Add(new Binding("Text", this.bds, "wx", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.dtpRzrq.DataBindings.Clear();
            this.dtpRzrq.DataBindings.Add(new Binding("Value", this.bds, "rzrq", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.dtpLzrq.DataBindings.Clear();
            this.dtpLzrq.DataBindings.Add(new Binding("Value", this.bds, "lzrq", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtXm.Text))
            {
                ClsMsgBox.Jg("姓名不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("账户不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("口令不可为空！");
                return;
            }
            if (txtPassword.Text.Length < minPwLen)
            {
                ClsMsgBox.Jg(string.Format("口令长度小于{0}！", minPwLen));
                return;
            }
            if (cmbRole.SelectedValue == null)
            {
                ClsMsgBox.Jg("角色不能为空！");
                return;
            }
            if (cmbJgTree.SelectedValue == null)
            {
                ClsMsgBox.Jg("下拉列表不能为空");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                tygTableAdapter1.Update(dsJckja1.tyg);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存员工时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckja1.tyg.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
        private void fillCmbXb()
        {
            List<ClsBhMcByte> lst = new List<ClsBhMcByte>();
            lst.Add(new ClsBhMcByte(1, "男"));
            lst.Add(new ClsBhMcByte(0, "女"));
            cmbXb.DataSource = lst;
            cmbXb.DisplayMember = "BhMc";
            cmbXb.ValueMember = "bh";
        }
        private void fillCmbRole()
        {
            string cmd = @"
SELECT id, mc FROM troles 
ORDER BY mc";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbRole.DataSource = dt;
            cmbRole.DisplayMember = "mc";
            cmbRole.ValueMember = "id";
        }
        private void fillCmbGw()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'gwlx'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbGw.DataSource = dt;
            cmbGw.DisplayMember = "dmmc";
            cmbGw.ValueMember = "dm";
        }
        private void fillCmbXl()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'xllx'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbXl.DataSource = dt;
            cmbXl.DisplayMember = "dmmc";
            cmbXl.ValueMember = "dm";
        }
        private void fillCmbZt()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'ryzt'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbZt.DataSource = dt;
            cmbZt.DisplayMember = "dmmc";
            cmbZt.ValueMember = "dm";
        }
        private void fillCmbs()
        {
            fillCmbJgTree(cmbJgTree.Tree);
            fillCmbXb();
            fillCmbRole();
            fillCmbGw();
            fillCmbXl();
            fillCmbZt();
        }

        private void fillCmbJgTree(TreeView trV)
        {
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0, id1, mc1, id2, mc2,
       id3, mc3, id4, mc4, id5, mc5 
FROM vjigoua 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string idFld, mcFld;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    idFld = "id" + i;
                    tns = trV.Nodes.Find(r[idFld].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        mcFld = "mc" + i;
                        tn = new TreeNode(r[idFld].ToString() + ":" + r[mcFld].ToString());
                        tn.Name = r[idFld].ToString();
                        tn.ImageIndex = 0;
                        tn.SelectedImageIndex = 1;
                        if (tp == null)
                            trV.Nodes.Add(tn);
                        else
                            tp.Nodes.Add(tn);
                        tp = tn;
                    }
                }            
        }
    }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = defaultPassword;
        }

    }
}