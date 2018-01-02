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
    public partial class FrmRolesXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSjckja dsJckja1;
        private trolesTableAdapter trolesTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmRolesXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSjckja aDSJckja,
           trolesTableAdapter atrolesTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckja1 = aDSJckja;
            trolesTableAdapter1 = atrolesTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckja1.troles);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
                DSjckja.trolesRow r = (DSjckja.trolesRow)((DataRowView)bds.Current).Row;
            }
            else if (NED == EnumNED.DETALL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void binding()
        {
            this.txtDm.DataBindings.Clear();
            this.txtDm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMc.DataBindings.Clear();
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtQx.DataBindings.Clear();
            this.txtQx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "qx", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("代码不可为空！");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("代码包含非字母数字字符！");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtQx.Text))
            {
                ClsMsgBox.Jg("权限不可为空！");
                return;
            }
            if (!ClsReg.Naturalnum.IsMatch(txtQx.Text))
            {
                ClsMsgBox.Jg("权限包含非字母数字字符！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                trolesTableAdapter1.Update(dsJckja1.troles);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存角色时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckja1.troles.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}