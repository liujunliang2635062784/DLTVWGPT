﻿using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public class ClsD
    {
        public static void TextBoxTrim(Control ctrl)
        {
            //foreach遍历（Control控件 c单个 in 多个控件） 
            foreach (Control c in ctrl.Controls)
            {
                //GroupBox组织界面
                //
                //
                if (c is GroupBox)
                    TextBoxTrim(c);
                else if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Text = t.Text.Trim();
                }
            }
        }
        #region SetMaxLength设置最大长度
        /// <summary>
        /// 为窗体上所有的绑定了system.string类型的数据表字段的textbox根据字段最大长度设置maxlength，
        /// 支持GroupBox的递归.
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tbl"></param>
        public static void SetMaxLength(Control ctrl, DataTable tbl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is GroupBox)
                    SetMaxLength(c, tbl);
                else if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Enabled && !t.ReadOnly)
                        if (t.DataBindings["Text"] != null)
                        {
                            string fld = t.DataBindings["text"].BindingMemberInfo.BindingField;
                            if (String.Compare(tbl.Columns[fld].DataType.ToString(), "System.String", true) == 0)
                            {
                                t.MaxLength = tbl.Columns[fld].MaxLength;
                             }
                        }
                }
            }
        }
        #endregion
        #region TurnDgvToBdsCurrRecdgv在新增记录时如果页数大于1则可以跳转到新增的记录的所在页
        public static void TurnDgvToBdsCurrRec(DataGridView dgv)
        {
            BindingSource bds = (BindingSource)dgv.DataSource;
            if (bds.Position == -1)
                return;
            int page = (int)Math.Ceiling(bds.Position / (decimal)dgv.ItemsPerPage);
            dgv.CurrentPage = page;
            //将当前记录显示在可见的DataGridView区域内
            dgv.FirstDisplayedScrollingRowIndex = bds.Position;
        }
        #endregion
    }
}
