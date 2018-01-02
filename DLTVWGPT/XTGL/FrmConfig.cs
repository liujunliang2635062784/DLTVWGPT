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
    public partial class FrmConfig : UserControl
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            nUDMinPWLen.Value = ClsMSSQL.GetConfigInt("MinPWLen", ClsDBCon.ConStrKj);
            txtPW.Text = ClsMSSQL.GetConfigStr("DefaultPassWord", ClsDBCon.ConStrKj);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtPW.Text.Trim();
            if (txtPW.Text.Length < nUDMinPWLen.Value)
            {
                ClsMsgBox.Jg("预置口令长度不足!");
                return;
            }
            ClsMSSQL.SetConfigItem("MinPWLen", nUDMinPWLen.Value, ClsDBCon.ConStrKj);
            ClsMSSQL.SetConfigItem("DefaultPassWord", txtPW.Text, ClsDBCon.ConStrKj);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}