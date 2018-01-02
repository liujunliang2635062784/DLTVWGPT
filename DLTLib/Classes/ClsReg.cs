using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
   public  class ClsReg
    {
        public static Regex Naturalnum
        {
            get
            {
                return new Regex(@"^\d+$");
            }
        }
        /// <summary>
        /// 关于字母数字的正则表达式。
        /// </summary>
        public static Regex AlphaNumeric
        {
            get
            {
                return new Regex(@"^[0-9a-zA-Z]+$");
            }
        }
        /// <summary>
        /// 关于人民币（2位小数）的正则表达式
        /// </summary>
        public static Regex RMB
        {
            get
            {
                return new Regex(@"^([1-9]\d*|0)(\.\d{0,2})?$"); 
            }
        }
    }
}
