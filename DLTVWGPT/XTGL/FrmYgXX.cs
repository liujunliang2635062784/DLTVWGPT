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
    public partial class FrmYgXX : Form
    {
        #region �Զ����Ա����
        private EnumNED NED;
        private BindingSource bds;
        private DSjckja dsJckja1;
        private tygTableAdapter tygTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmYgXX()
        {
            InitializeComponent();
        }
        public void Prepare(EnumNED aNED, BindingSource aBds, DSjckja aDSJckja,
           tygTableAdapter atygTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckja1 = aDSJckja;
            tygTableAdapter1 = atygTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckja1.tyg);
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
            this.txtxh.DataBindings.Clear();
            this.txtxh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtxm.DataBindings.Clear();
            this.txtxm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xm", true,
                DataSourceUpdateMode.OnPropertyChanged));           
            this.txtQQ.DataBindings.Clear();
            this.txtQQ.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "QQ", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtotel.DataBindings.Clear();
            this.txtotel.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "otel", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtfax.DataBindings.Clear();
            this.txtfax.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "fax", true,
                DataSourceUpdateMode.OnPropertyChanged));           
            this.txtemail.DataBindings.Clear();
            this.txtemail.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "email", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtwx.DataBindings.Clear();
            this.txtwx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "wx", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region ��ֵ�ж�
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtfax.Text))
            {
                ClsMsgBox.Jg("���治��Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtmetl.Text))
            {
                ClsMsgBox.Jg("���벻��Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtQQ.Text))
            {
                ClsMsgBox.Jg("QQ����Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtwx.Text))
            {
                ClsMsgBox.Jg("΢�Ų���Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtxm.Text))
            {
                ClsMsgBox.Jg("��������Ϊ�գ�");
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtfax.Text))
            {
                ClsMsgBox.Jg("�����������ĸ�����ַ���");
                return;
            }
            if (string.IsNullOrEmpty(txtxh.Text))
            {
                ClsMsgBox.Jg("��Ų���Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                ClsMsgBox.Jg("���䲻��Ϊ�գ�");
                return;
            }
            if (!ClsReg.Naturalnum.IsMatch(txtemail.Text))
            {
                ClsMsgBox.Jg("Ȩ�ް�������ĸ�����ַ���");
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
                ClsMsgBox.Cw("����Ա��ʱ�����˴���", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckja1.tyg.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
       
    }
}