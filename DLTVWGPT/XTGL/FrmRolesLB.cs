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
    public partial class FrmRolesLB : UserControl
    {
        public FrmRolesLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            trolesTableAdapter1.Fill(dSjckja1.troles);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.NEW, bds, dSjckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.EDIT, bds, dSjckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.DETALL, bds, dSjckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            Datasets.DSjckja.trolesRow r = (Datasets.DSjckja.trolesRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("������´�����Ŀ�޷�ɾ��");
                return;
            }
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                trolesTableAdapter1.Update(dSjckja1.troles);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnFuncs_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            DSjckja.trolesRow r = (DSjckja.trolesRow)(((DataRowView)bds.Current).Row);
            if (r.qx < 1024)
            {
                ClsMsgBox.Jg("�ý�ɫΪϵͳ�������ɫ������Ҫ���ÿɷ��ʵĹ���ģ�顣");
                return;
            }
            FrmRoleFuncs f = new FrmRoleFuncs();
            f.Prepare(r.id, r.mc);
            f.ShowDialog();
        }
    }
}