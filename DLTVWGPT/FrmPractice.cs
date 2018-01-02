#region Using

using DLTLib.Classes;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;

#endregion

namespace DLTVWGPT
{
    public partial class FrmPractice : UserControl
    {
        public FrmPractice()
        {
            InitializeComponent();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            //testQ();
            //testDBCon();
            //testMsgBox();
            //testGetDataTable();
            //testGetDataTableException();
            //testExits1();
            //testExits2();
            //testYgBB1();
            //testYgBB1a();
            //testYgBB1b();
            //testYgBB1c();
            //testYgBB1d();
            //testYgBBcs();
            testYgBBcsa();
            
        }

        private void testYgBBcsa()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            xms = HttpUtility.UrlEncode(xms);
            string bbURL = "/GRBB/YgBBa.aspx?where=" + sWhere + "&xms=" + xms;
            Link.Open(bbURL, paras);
        }

        private void testYgBBcs()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            xms = HttpUtility.UrlEncode(xms);
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere + "&xms=" + xms;
            Link.Open(bbURL, paras);
        }
        private string getXMs()
        {
            string cmd = @"
SELECT mc FROM toptionxm
WHERE lbdm='xllx'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            var a = from r in dt.AsEnumerable()
                    select r.Field<string>("mc");
            string[] xma = a.ToArray();
            string xms = string.Join(",", xma);
            return xms;
        }
        private void testYgBB1d()
        {
            LinkParameters paras = new LinkParameters();
            //空白的窗口
            paras.Target = "_blank";
            //全画面的
            paras.FullScreen = false;
            //可调节大小的
            paras.Resizable = true;
            //设置滚动条模块
            paras.ScrollBars = true;
            //操作显示或隐藏‘加载项’
            paras.ShowToolBar = true;
            //菜单显示
            paras.ShowMenuBar = true;
            //标题条
            paras.ShowTitleBar = true;
            //状态条
            paras.ShowStatusBar = true;
            //系统窗口
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WhERE xbs='男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL, paras);
        }

        private void testYgBB1c()
        {
            LinkParameters paras = new LinkParameters();
            //空白的窗口
            paras.Target = "_blank";
            //全画面的
            paras.FullScreen = false;
            //可调节大小的
            paras.Resizable = true;
            //设置滚动条模块
            paras.ScrollBars = true;
            //操作显示或隐藏‘加载项’
            paras.ShowToolBar = true;
            //菜单显示
            paras.ShowMenuBar = true;
            //标题条
            paras.ShowTitleBar = true;
            //状态条
            paras.ShowStatusBar = true;
            //系统窗口
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WhERE xbs='男' ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL, paras);
        }
        private void testYgBB1b()
        {
            LinkParameters paras = new LinkParameters();
            //空白的窗口
            paras.Target = "_blank";
            //全画面的
            paras.FullScreen = false;
            //可调节大小的
            paras.Resizable = true;
            //设置滚动条模块
            paras.ScrollBars = true;
            //操作显示或隐藏‘加载项’
            paras.ShowToolBar = true;
            //菜单显示
            paras.ShowMenuBar = true;
            //标题条
            paras.ShowTitleBar = true;
            //状态条
            paras.ShowStatusBar = true;
            //系统窗口
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WhERE xb=0 ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where="+sWhere;
            Link.Open(bbURL, paras);
        }

        private void testYgBB1a()
        {
            LinkParameters paras = new LinkParameters();
            //空白的窗口
            paras.Target = "_blank";
            //全画面的
            paras.FullScreen = false;
            //可调节大小的
            paras.Resizable = true;
            //设置滚动条模块
            paras.ScrollBars = true;
            //操作显示或隐藏‘加载项’
            paras.ShowToolBar = true;
            //菜单显示
            paras.ShowMenuBar = true;
            //标题条
            paras.ShowTitleBar = true;
            //状态条
            paras.ShowStatusBar = true;
            //系统窗口
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YGBB.aspx",paras);
        }

        private void testYgBB1()
        {
           
            LinkParameters paras = new LinkParameters();
            //空白的窗口
            paras.Target = "_blank";
            //全画面的
            paras.FullScreen = false;
            //可调节大小的
            paras.Resizable = true;
            //设置滚动条模块
            paras.ScrollBars = true;
            //操作显示或隐藏‘加载项’
            paras.ShowToolBar = true;
            //菜单显示
            paras.ShowMenuBar = true;
            //标题条
            paras.ShowTitleBar = true;
            //状态条
            paras.ShowStatusBar = true;
            //系统窗口
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YgBBData.aspx",paras);
        }
        private void testExits2()
        {
            bool b;
            b = ClsMSSQL.Exists("tlogin", "loginname", txtA.Text, ClsDBCon.ConStrKj);
            lst.Items.Add(b);
        }
        private void testExits1()
        {
            bool b;
            string cmd = string.Format("SELECT * FROM tlogin WHERE loginname LIKE '%{0}%'", txtA.Text);
            Debug.WriteLine(cmd);
            Debug.WriteLine(ClsDBCon.ConStrKj);
            b = ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj);
            lst.Items.Add(b);
            lst.Items.Add(cmd);
            lst.Items.Add(ClsDBCon.ConStrKj);
        }
       private void testGetDataTableException()
        {
            string cmd = "SELECT * FROM tlogina";
            try
            {
                DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
                dgv.DataSource = dt;
                tcA.SelectedTab = tpDgv;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw(ex.Message);
            }
        }
        private void testGetDataTable()
        {
            string cmd = "SELECT * FROM tlogin";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            dgv.DataSource = dt;
            tcA.SelectedTab = tpDgv;
        }
        private void testMsgBox()
        {
            ClsMsgBox.Ts(txtA.Text);
            ClsMsgBox.Jg(txtA.Text);
            ClsMsgBox.Cw(txtA.Text);
        }
        private void testDBCon()
        {
            lst.Items.Add(ClsDBCon.ConStrKj);
        }
        private void testQ()
        {
            lst.Items.Add(ClsQ.Q1(txtA.Text));
            lst.Items.Add(ClsQ.Q2(txtA.Text));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '('));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '['));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '‘'));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '“'));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }    
    }
}