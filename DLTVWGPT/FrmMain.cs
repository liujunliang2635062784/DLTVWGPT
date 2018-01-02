#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTVWGPT.Classes;
using DLTLib.Classes;
using System.Reflection;
using System.Text.RegularExpressions;

#endregion

namespace DLTVWGPT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            showStat();
            ClsFuncsA funcs = new ClsFuncsA(tpMain);
            funcsTree.Prepare(funcs);
        }
        private void showStat()
        {
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLBlUser.Text = "�û���" + userRow["xm"].ToString();
            #region ��ʾ�汾�Ͱ�Ȩ��Ϣ
            //��ǰϵͳ�İ汾��
            Assembly a = Assembly.GetExecutingAssembly();//��ȡ��ǰִ�д���ĳ���
            AssemblyName an = a.GetName();//��ȡ�γ��򼯵�AssemblyName
            tssLblVer.Text = "�汾��" + an.Version.ToString();
            //VWG�İ汾��
            //VWG�汾��Gizmox.WebGUI.WGConst.Version��ȡ������10.0.5 d=2016.01.31 04:13 PM GMT+2
            //״̬������ʾ�汾���뷢������
            String s = Gizmox.WebGUI.WGConst.Version;//��ǰ��Visual WebGui�汾
            Regex r = new Regex("[0-9]?[0-9]+:");//ƥ�䡰04���� ���ָ����������ʽ��ʼ��Regex�����ʵ��
            Match m = r.Match(s);//����������ʽƥ��Ľ��
            //�Ӵ�ʵ���������ַ��������ַ�����ָ�����ַ�λ�ÿ�ʼ������ָ���ĳ���
            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);
            //��Ȩ��Ϣ
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;      
            #endregion
        }
        private void lblTop_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "��" : "��";
        }
        private void lblLeft_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }
        private void tsBtnLogout_Click(object sender, EventArgs e)
        {
            ClsMsgBox.YesNo("ȷʵҪ�˳�ϵͳ��", logout);
        }
        private void logout(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
        }
        private void tsMTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            string ids = funcsTree.trV.SelectedNode.Name;
            funcsTree.trV.Nodes.Clear();
            ClsFuncsA funcs = new ClsFuncsA(tpMain);
            funcsTree.Prepare(funcs);
            funcsTree.trV.ExpandAll();
            TreeNode[] tns = funcsTree.trV.Nodes.Find(ids, true);
            if (tns.Length > 0)
            {
                funcsTree.trV.SelectedNode = tns[0];
            }
            else
                funcsTree.trV.SelectedNode = funcsTree.trV.Nodes[0];
        }    
    }    
}