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

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmYgLB : UserControl
    {
        public FrmYgLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            tygTableAdapter1.Fill(dSjckja1.tyg);
        }

       
        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                tygTableAdapter1.Update(dSjckja1.tyg);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
    }
}