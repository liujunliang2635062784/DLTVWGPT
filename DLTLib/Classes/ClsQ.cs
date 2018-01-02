using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    /// <summary>
    /// 在字符串两端添加引号或括号等符号
    /// </summary>
    public class ClsQ
    {
        /// <summary>
        /// 在字符串两端添加英文单引号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Q1(string s)
        {
            return Q0(s, '\'');
        }
        public static string Q2(string s)
        {
            return Q0(s, '\"');
        }
        /// <summary>
        /// <para>在字符串两端添加单引号、双引号、或括号，</para>
        /// <para>引号包括英文的和中文的。</para>
        /// </summary>
        /// <param name="s"></param>
        /// <param name="quoter"></param>
        /// <returns></returns>
        public static string Q0(string s, char quoter)
        {
            char[] quoters = { '"', '\'', '(', '[', '‘', '“' };
            if (!quoters.Contains(quoter))
                return s;
            else
                switch (quoter)
                {
                    case '"':
                        return '"' + s + '"';
                    case '\'':
                        return '\'' + s + '\'';
                    case '(':
                        return '(' + s + ')';
                    case '[':
                        return '[' + s + ']';
                    case '‘':
                        return '‘' + s + '’';
                    case '“':
                        return '“' + s + '”';
                    default:
                        return s;
                }
        }
    }
}