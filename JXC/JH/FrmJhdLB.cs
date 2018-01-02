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

#endregion

namespace JXC.JH
{
    public partial class FrmJhdLB : UserControl
    {
        private DataTable dtJhdHj;
        public FrmJhdLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            createTableAndRelation();
            dsJxc.tjhd.TableNewRow += Tjhd_TableNewRow;
            dsJxc.tjhd.ColumnChanged += Tjhd_ColumnChanged;
            tjhdTableAdapter1.Fill(dsJxc.tjhd);
        }

        private void Tjhd_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            int id = Convert.ToInt32(e.Row["id"]);
            if (dtJhdHj.Select(string.Format("jhdid={0}", id)).Length == 0)
                dtJhdHj.Rows.Add(new object[] { id,0});
                
        }

        private void Tjhd_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.Equals("id", StringComparison.CurrentCultureIgnoreCase) && e.Row.HasVersion(DataRowVersion.Original) && Convert.ToInt32(e.Row["id", DataRowVersion.Original]) < 0)
            {
                int id = Convert.ToInt32(e.Row["id", DataRowVersion.Original]);
                DataRow[] r = dtJhdHj.Select(string.Format("jhdid={0}", id));
                if (r.Length > 0)
                    r[0]["jhdid"] = e.Row["id"];
             }
        }

        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT jhdid, sum(sl*dj) AS hj FROM tjhmx GROUP BY jhdid ORDER BY jhdid";
            dtJhdHj = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrJxc);
            dtJhdHj.TableName = "vjhdhj";
            dsJxc.Tables.Add(dtJhdHj);
            DataRelation rel;
            rel = new DataRelation("jhdhj", dtJhdHj.Columns["jhdid"], dsJxc.tjhd.idColumn);
            dsJxc.Relations.Add(rel);
            dsJxc.tjhd.hjaColumn.Expression = "Parent(jhdhj).hj";
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
                tjhdTableAdapter1.Update(dsJxc.tjhd);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.NEW, bds, dsJxc, tjhdTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.EDIT, bds, dsJxc, tjhdTableAdapter1, dgv);
            f.ShowDialog();

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据库为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.DETALL, bds, dsJxc, tjhdTableAdapter1, dgv);
            f.ShowDialog();

        }
    }
}