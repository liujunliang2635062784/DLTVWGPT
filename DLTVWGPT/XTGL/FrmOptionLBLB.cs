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

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmOptionLBLB : UserControl
    {
        private Datasets.DSjckja.toptionlbRow lbRow;
        public FrmOptionLBLB()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            toptionlbTableAdapter1.Fill(dSjckja1.toptionlb);
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.NEW, bds, dSjckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.EDIT, bds, dSjckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.DETALL, bds, dSjckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            Datasets.DSjckja.toptionlbRow r = (Datasets.DSjckja.toptionlbRow)(((DataRowView)bds.Current).Row);
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
                toptionlbTableAdapter1.Update(dSjckja1.toptionlb);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM,dSjckja1, toptionxmTableAdapter1, dgvXM, lbRow.dm);
            f.ShowDialog();
        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dSjckja1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDetailXM_Click(object sender, EventArgs e)
        {

            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETALL, bdsXM, dSjckja1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deletingXM);
        }
        private void deletingXM(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsXM.RemoveCurrent();
                toptionxmTableAdapter1.Update(dSjckja1.toptionxm);
                ClsD.TurnDgvToBdsCurrRec(dgvXM);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (bds.Current == null)
            {
                lbRow = null;
                return;
            }
            lbRow = (Datasets.DSjckja.toptionlbRow)(((DataRowView)bds.Current).Row);
            //����һ�ε��� AcceptChanges ֮�󣬸���δ���ġ�
            //�þ�������Ƿ�ֹ��toptionlb�����ӻ�ɾ����¼ʱ, 
            //ִ�е������r.dm��r.mc�ĸ�ֵ���ʱ��r��Ӧ�Ķ���Ϊnull��������
            if (lbRow.RowState == DataRowState.Unchanged)
            {
                toptionxmTableAdapter1.FillByLbdm(dSjckja1.toptionxm, lbRow.dm);
            }
            else
                //�˾������toptionxm���д�ǰװ��Ķ�Ӧ����ѡ������ѡ����Ŀ
                dSjckja1.toptionxm.Clear();
        }
    }
    
}