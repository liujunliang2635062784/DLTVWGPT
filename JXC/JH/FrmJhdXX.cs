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
using JXC.Datasets;
using JXC.Datasets.DSJxcTableAdapters;

#endregion

namespace JXC.JH
{
    public partial class FrmJhdXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc dsJxc1;
        private tjhdTableAdapter tjhdTableAdapter1;
        private DataGridView dgvMaster;
        #endregion
        public FrmJhdXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc aDSJxc,
           tjhdTableAdapter atjhdTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            tjhdTableAdapter1 = atjhdTableAdapter1;
            dgvMaster = aDgv;
            initMX();
            bindDgv();
            ClsD.SetMaxLength(this, dsJxc1.tjhd);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();                
            }
            else if (NED == EnumNED.DETALL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void bindDgv()
        {
            dgv.DataSource = bdsMX;
            colId.DataPropertyName = "id";
            colXh.DataPropertyName = "xh";
            colPm.DataPropertyName = "pm";
            colBm.DataPropertyName = "bm";
            colDw.DataPropertyName = "dw";
            colSl.DataPropertyName = "sl";
            colDj.DataPropertyName = "dj";
            colJhdId.DataPropertyName = "jhdid";
            colJe.DataPropertyName = "je";
        }
        private void initMX()
        {
            bdsMX.DataSource = bds;
            bdsMX.DataMember = "FK_tjhmx_tjhd";
            tableAdapterManager1.tjhdTableAdapter = new tjhdTableAdapter();
            tableAdapterManager1.tjhmxTableAdapter = new tjhmxTableAdapter();
            if (NED != EnumNED.NEW)
            {               
                tjhmxTableAdapter1.FillByJhdId(dsJxc1.tjhmx, Int32.Parse(lblId.Text));
            }
        }
        private void binding()
        {
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxr.DataBindings.Clear();
            this.txtLxr.DataBindings.Add(new Binding("Text", this.bds, "lxr", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtGhsh.DataBindings.Clear();
            this.txtGhsh.DataBindings.Add(new Binding("Text", this.bds, "ghsh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxdh.DataBindings.Clear();
            this.txtLxdh.DataBindings.Add(new Binding("Text", this.bds, "lxdh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtJhdh.DataBindings.Clear();
            this.txtJhdh.DataBindings.Add(new Binding("Text", this.bds, "jhdh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.lblHj.DataBindings.Clear();
            this.lblHj.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "hj", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtJhdh.Text))
            {
                ClsMsgBox.Jg("进货单不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtGhsh.Text))
            {
                ClsMsgBox.Jg("供货单不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                tableAdapterManager1.UpdateAll(dsJxc1);
                DataTable dt = dsJxc.Tables["vjhmxhj"];
                DataRow[] r = dt.Select(string.Format("jhdId={0}", lblId.Text));
                if (r.Length > 0)
                    r[0]["hj"] = string.IsNullOrEmpty(lblHj.Text) ? "0" : lblHj.Text;
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgvMaster);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货单时遇到了错误：", ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc1.tjhd.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.EDIT, bdsMX, dsJxc1, tjhmxTableAdapter1);
            f.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bds.EndEdit();
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.NEW, bdsMX, dsJxc1, tjhmxTableAdapter1,Convert.ToInt32(lblId.Text),dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsMX.RemoveCurrent();
                tjhmxTableAdapter1.Update(dsJxc1.tjhmx);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.DETALL, bdsMX, dsJxc1, tjhmxTableAdapter1);
            f.ShowDialog();
        }
    }
}