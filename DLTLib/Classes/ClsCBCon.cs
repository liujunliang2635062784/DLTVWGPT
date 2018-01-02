using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public static class ClsDBCon
    {
        static ClsDBCon()
        {
            ConStrKj = ConfigurationManager.ConnectionStrings["dltjckjaConnectionString"].ConnectionString;
            ConStrJxc = ConfigurationManager.ConnectionStrings["jxcConnectionString"].ConnectionString;
        }
        /// <summary>
        /// 基础框架数据库连接串                                
        /// </summary>
        public static string ConStrKj { get; set; }
        /// <summary>
        ///连接数据库的操作，在[]里代表要连接的数据库名称 
        /// </summary>
        public static string ConStrJxc { get; set; }

    }
}
