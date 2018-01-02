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
    public partial class FrmJGGL : UserControl
    {
        public FrmJGGL()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            createJgTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            fillCmbs();
        }
        #region 为ComboBox填充下拉选项
        private void fillCmbs()
        {
            fillCmbBmlx();
        }
        private void fillCmbBmlx()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'bnlx'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbBmlx.DataSource = dt;
            cmbBmlx.DisplayMember = "dmmc";
            cmbBmlx.ValueMember = "dm";
        }
        #endregion
        private void createJgTree()
        {
            string cmd = @"
SELECT id,mc,jb,
       id0, mc0,id1, mc1,id2, mc2,
       id3, mc3,id4, mc4,id5, mc5
FROM vjigoua
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 0; i <= jb; i++)
                {
                    id = "id" + i;
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            return tn;
        }
        private void FrmMKGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                int id = Int32.Parse(e.Node.Name);
                tjigouTableAdapter1.FillById(dSjckja1.tjigou, id);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bds.EndEdit();
            ClsD.TextBoxTrim(grpMain);
            if (string.IsNullOrEmpty(txtMC.Text))
            {
                ClsMsgBox.Jg("序号不可为空！");
                txtMC.Focus();
                return;
            }            
            try
            {
                tjigouTableAdapter1.Update(dSjckja1.tjigou);
                trV.SelectedNode.Name = lblld.Text;
                trV.SelectedNode.Text = txtJc.Text;
                if (!trV.Enabled)
                    trV.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存机构信息时遇到了如下错误：", ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dSjckja1.tjigou.RejectChanges();
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                if (tn.Parent == null)
                {
                    trV.Nodes.Remove(tn);
                }
                else
                {
                    tn.Parent.Nodes.Remove(tn);
                }
                trV.Enabled = true;
            }
        }
        private void mnuNewbrother_Click(object sender, EventArgs e)
        {
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            if (trV.SelectedNode.Level == 0)
            {
                ClsMsgBox.Jg("不允许为根结点添加同级结点。");
                return;
            }
            trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSjckja1.tjigou.Rows.Clear();
            DSjckja.tjigouRow r = (DSjckja.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level);
            r.pid = Int32.Parse(tn.Parent.Name);
        }
        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 5)
            {
                ClsMsgBox.Jg("机构层次不允许超过5级。");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSjckja1.tjigou.Rows.Clear();
            DSjckja.tjigouRow r = (DSjckja.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level);
            r.pid = Int32.Parse(tn.Parent.Name);
        }
        private void mnuDel_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 0)
                ClsMsgBox.Jg("本结点为根结点，不允许删除！");
            else if(trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("本结点不是末端结点，不允许删除！");
            else
                ClsMsgBox.YesNo("确实要删除当前机构吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //删除数据库中的机构记录
                string cmd = string.Format("DELETE FROM tjigou WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsDBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("删除机构表命令影响的记录行数{0}不为1。", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //删除机构树中的结点
                    TreeNode tn = trV.SelectedNode;
                    TreeNode tm = tn.NextNode != null ? tn.NextNode :
                        tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                    trV.SelectedNode = tm;
                    if (tn.Level == 0)
                        trV.Nodes.Remove(tn);
                    else
                        tn.Parent.Nodes.Remove(tn);
                }
            }
        }
    }
}