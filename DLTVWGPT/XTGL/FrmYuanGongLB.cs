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
    public partial class FrmYuanGongLB : UserControl
    {
   
        public FrmYuanGongLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
     
            Prepare();
        }
        public void Prepare()
        {
            tjigouTableAdapter1.Fill(dSjckja1.tjigou);
            trolesTableAdapter1.Fill(dSjckja1.troles);
            createTableAndRelation();
            tygTableAdapter1.Fill(dSjckja1.tyg);
        }
        private void createTableAndRelation()
        {
            String cmd;
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='gwlx' ORDER BY dm";
            DataTable dtGw = ClsMSSQL.GetDataTable(cmd,ClsDBCon.ConStrKj);
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='xllx' ORDER BY dm";
            DataTable dtxl = ClsMSSQL.GetDataTable(cmd,ClsDBCon.ConStrKj);
            dSjckja1.Tables.Add(dtGw);
            dSjckja1.Tables.Add(dtxl);
            DataRelation rel;
            rel = new DataRelation("tyg_gwlx", dtGw.Columns["dm"], dSjckja1.tyg.gwColumn);
            dSjckja1.Relations.Add(rel);
            rel = new DataRelation("tyg_xllx", dtxl.Columns["dm"], dSjckja1.tyg.xlColumn);
            dSjckja1.Relations.Add(rel);
            dSjckja1.tyg.gwsColumn.Expression = "Parent(tyg_gwlx).mc";
            dSjckja1.tyg.xlsColumn.Expression = "Parent(tyg_xllx).mc";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmYuanGongXX f= new FrmYuanGongXX();
            f.Prepare(EnumNED.NEW, bds, dSjckja1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.EDIT, bds, dSjckja1, tygTableAdapter1, dgv);
            f.ShowDialog();
            
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.DETALL, bds, dSjckja1, tygTableAdapter1, dgv);
            f.ShowDialog();

        }
    }
}