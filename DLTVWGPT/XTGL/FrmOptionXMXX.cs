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
    public partial class FrmOptionXMXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSjckja dsJckja1;
        private toptionxmTableAdapter toptionxmTableAdapter1;
        private DataGridView dgvXM;
        #endregion
        public FrmOptionXMXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSjckja aDSJckja,
           toptionxmTableAdapter atoptionxmTableAdapter1, DataGridView aDgv = null,string aLbdm=null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckja1 = aDSJckja;
            toptionxmTableAdapter1 = atoptionxmTableAdapter1;
            dgvXM = aDgv;
            ClsD.SetMaxLength(this,dsJckja1.toptionxm);
            if (NED == EnumNED.NEW)
            {
                DSjckja.toptionxmRow r = (DSjckja.toptionxmRow)((DataRowView)bds.AddNew()).Row;
                r.lbdm = aLbdm;
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
            #endregion
            try
            {
                bds.EndEdit();
                toptionxmTableAdapter1.Update(dsJckja1.toptionxm);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgvXM);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存选项项目时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckja1.toptionxm.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmOptionXMXX_Load(object sender, EventArgs e)
        {

        }
    }
}