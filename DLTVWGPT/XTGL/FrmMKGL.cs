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
    public partial class FrmMKGL : UserControl
    {
        private int rootId;
        public FrmMKGL()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            string cmd = "SELECT id FROM tfuncs WHERE bm = 'root'";
            rootId = Convert.ToInt32(ClsMSSQL.GetValue(cmd, ClsDBCon.ConStrKj));
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        private void createFuncTree()
        {
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
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
                for (int i = 1; i <= jb; i++)
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
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
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
            tfuncsTableAdapter1.FillById(dSjckja1.tfuncs, id);
             }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bds.EndEdit();
            ClsD.TextBoxTrim(grpMain);
            if (string.IsNullOrEmpty(txtXh.Text))
            {
                ClsMsgBox.Jg("序号不可为空！");
                txtXh.Focus();
                return;
            }
            if (!ClsReg.Naturalnum.IsMatch(txtXh.Text))
            {
                ClsMsgBox.Jg("序号必须为数字！");
                txtXh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                txtMc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("编码不可为空！");
                txtBm.Focus();
                return;
            }
            try
            {
                tfuncsTableAdapter1.Update(dSjckja1.tfuncs);
                trV.SelectedNode.Name = lblld.Text;
                trV.SelectedNode.Text = txtMc.Text;
                trV.SelectedNode.Tag = txtBm.Text;
                if (!trV.Enabled)
                    trV.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存模块信息时遇到了如下错误：", ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dSjckja1.tfuncs.RejectChanges();
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
                trV.Nodes.Add(tn);
            }
            else
                trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSjckja1.tfuncs.Rows.Clear();
            DSjckja.tfuncsRow r = (DSjckja.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1);
            r.pid = tn.Level == 0 ? rootId :
            Int32.Parse(tn.Parent.Name);
        }
        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 4)
            {
                ClsMsgBox.Jg("模块层次不允许超过5级。");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSjckja1.tfuncs.Rows.Clear();
            DSjckja.tfuncsRow r = (DSjckja.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1);
            r.pid = Int32.Parse(tn.Parent.Name);
        }
        private void mnuDel_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("本结点不是末端结点，不允许删除！");
            else
                ClsMsgBox.YesNo("确实要删除当前模块吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //删除数据库中的模块记录
                string cmd = string.Format("DELETE FROM tfuncs WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsDBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("删除模块表命令影响的记录行数{0}不为1。", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //删除模块树中的结点
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