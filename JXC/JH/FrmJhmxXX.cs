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
    public partial class FrmJhmxXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc dsJxc;
        private tjhmxTableAdapter tjhmxTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmJhmxXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc aDSJxc,
           tjhmxTableAdapter atjhmxTableAdapter1, int aJhdId=0, DataGridView aDgv = null)
        {

            bds = aBds;
            binding();
            NED = aNED;
            dsJxc = aDSJxc;
            tjhmxTableAdapter1 = atjhmxTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJxc.tjhmx);
            if (NED == EnumNED.NEW)
            {
                DSJxc.tjhmxRow r = (DSJxc.tjhmxRow)((DataRowView)bds.AddNew()).Row;
                r.jhdid= aJhdId;
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
            this.txtPm.DataBindings.Clear();
            this.txtPm.DataBindings.Add(new Binding("Text", this.bds, "pm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtBm.DataBindings.Clear();
            this.txtBm.DataBindings.Add(new Binding("Text", this.bds, "bm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtXh.DataBindings.Clear();
            this.txtXh.DataBindings.Add(new Binding("Text", this.bds, "xh", true,
                DataSourceUpdateMode.OnPropertyChanged));          
            this.txtDw.DataBindings.Clear();
            this.txtDw.DataBindings.Add(new Binding("Text", this.bds, "dw", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtDj.DataBindings.Clear();
            this.txtDj.DataBindings.Add(new Binding("Text", this.bds, "dj", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtSl.DataBindings.Clear();
            this.txtSl.DataBindings.Add(new Binding("Text", this.bds, "sl", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.lblJe.DataBindings.Clear();
            this.lblJe.DataBindings.Add(new Binding("Text", this.bds, "je", true,
                DataSourceUpdateMode.OnValidation));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (!ClsReg.Naturalnum.IsMatch(txtXh.Text))
            {
                ClsMsgBox.Jg("序号必须为整数！");
            }
            if (string.IsNullOrEmpty(txtPm.Text))
            {
                ClsMsgBox.Jg("品名不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("编码不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtDw.Text))
            {
                ClsMsgBox.Jg("单位不可为空！");
                return;
            }
            if (!ClsReg.RMB.IsMatch(txtDj.Text))
            {
                ClsMsgBox.Jg("单价数据不正确！");
                return;
            }
            if (!ClsReg.Naturalnum.IsMatch(txtSl.Text))
            {
                ClsMsgBox.Jg("数量必须为整数！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货明细时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc.tjhmx.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtDj_Leave(object sender, EventArgs e)
        {
            if (ClsReg.RMB.IsMatch(txtDj.Text) && ClsReg.Naturalnum.IsMatch(txtSl.Text))
                bds.EndEdit();
        }
    }
}