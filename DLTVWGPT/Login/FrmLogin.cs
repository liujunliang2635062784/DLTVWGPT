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
using Gizmox.WebGUI.Forms.Authentication;
using DLTLib.Classes;
using DLTVWGPT.Datasets.DSjckjaTableAdapters;
using DLTVWGPT.Datasets;

#endregion

namespace DLTVWGPT.Login
{
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }
        private void readCookie()
        {
            //��ȡcookie�е�ֵ
            //Context.Cookies��VWGContext.Current.Cookies��ͬһ������
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //�ж�Cookies��ֵ�Ƿ���ֵ
            if (cookieAccount != "" && cookiePassword != "")
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }
        }    
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region �˻������Ϊ���ж�
            txtLoginName.Text = txtLoginName.Text.Trim();
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("�˻�����Ϊ�գ�");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("�����Ϊ�գ�");
                return;
            }
            #endregion



            //��ȡ�û���Ϣ
            vusersTableAdapter uta = new vusersTableAdapter();
            DSjckja.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            DSjckja.vusersRow userRow = u.Rows.Count == 0 ? null : (DSjckja.vusersRow)u.Rows[0];
            #region  �˻���������Ч���ж�
            if (userRow == null)
            {
                ClsMsgBox.Jg("�˻������ڣ�");
                return;
            }
            //�жϿ���
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
                ClsMsgBox.Jg("�����ȷ��");
                return;
            }
            //�жϻ״̬
            if (!userRow.active)
            {
                ClsMsgBox.Jg("���û�Ϊ�ǻ�û����������¼ϵͳ��");
                return;
            }
            #endregion
            #region �Ƿ񱣴浽cookie
            if (chkAutoSave.Checked)
            {
                Context.Cookies["Account"] = txtLoginName.Text;
                Context.Cookies["Password"] = txtPassword.Text;
            }
            else
            {
                Context.Cookies["Account"] = "";
                Context.Cookies["Password"] = "";
            }
            #endregion
            //����½�û���Ϣ���浽session
            VWGContext.Current.Session["userRow"] = userRow;
            this.Context.Session.IsLoggedOn = true;//�����ʵ�ʵĴ���
        }
    }
}