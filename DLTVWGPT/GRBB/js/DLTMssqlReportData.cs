using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.IO.Compression;

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  DLTSqlReportData 产生提供给报表生成需要的 或 JSON 数据
public class DLTSqlReportData
{
    //★特别提示★：
    //连接SQL Server数据库的连接串，应该修改为与实际一致。如果是运行Grid++Report本身的例子，应该首先附加例子数据库到
    //SQL Server2000/2005数据库上。
    // public const string SqlConnStr = "Data Source=(local);Initial Catalog=gridreport;Persist Security Info=True;User ID=sa;Password=;";
   /*public static string SqlConnStr
    {
        get { return ClsDBCon.ConStrKj; }
    }*/
    //定义在SQL中表示日期值的包围符号，Access用“#”, 而MS SQl Server用“'”，为了生成两者都可用的查询SQL语句，将其参数化定义出来。这样处理只是为了演示例子方便
    public const char DateSqlBracketChar = '\'';

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，字段值为空也产生数据
    public static void FullGenNodeXmlData(System.Web.UI.Page DataPage, string QuerySQL, bool ToCompress,string SqlConnStr)
    {
        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        SqlCommand ReportDataCommand = new SqlCommand(QuerySQL, ReportConn);
        ReportConn.Open();
        SqlDataReader ReportDataReader = ReportDataCommand.ExecuteReader();
        XMLReportData.GenNodeXmlDataFromReader(DataPage, ReportDataReader, ToCompress? ResponseDataType.ZipBinary : ResponseDataType.PlainText);
        ReportDataReader.Close();
        ReportConn.Close();
    }

    //获取 Count(*) SQL 查询到的数据行数。参数 QuerySQL 指定获取报表数据的查询SQL
    public static int BatchGetDataCount(string QuerySQL,string SqlConnStr)
    {
        int Total = 0;

        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        SqlCommand ReportDataCommand = new SqlCommand(QuerySQL, ReportConn);
        ReportConn.Open();
        SqlDataReader ReportDataReader = ReportDataCommand.ExecuteReader();
        if (ReportDataReader.Read())
            Total = ReportDataReader.GetInt32(0);
        ReportDataReader.Close();
        ReportConn.Close();

        return Total;
    }

    //<<protected function
    //根据查询SQL,产生提供给报表生成需要的 XML 或 JSON 数据
    protected static void DoGenDetailData(System.Web.UI.Page DataPage, string QuerySQL, ResponseDataType DataType, bool IsJSON, string SqlConnStr)
    {
        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        SqlDataAdapter ReportDataAdapter = new SqlDataAdapter(QuerySQL, ReportConn);
        DataSet ReportDataSet = new DataSet();
        ReportConn.Open();
        ReportDataAdapter.Fill(ReportDataSet);
        ReportConn.Close();

        if (IsJSON)
            JSONReportData.GenDataSet(DataPage, ReportDataSet, DataType);
        else
            XMLReportData.GenDataSet(DataPage, ReportDataSet, DataType);
    }
    //>>protected function

    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 Sql 数据引擎
    public static void GenNodeXmlData(System.Web.UI.Page DataPage, string QuerySQL, bool ToCompress,string SqlConnStr)
    {
        DoGenDetailData(DataPage, QuerySQL, ToCompress ? ResponseDataType.ZipBinary : ResponseDataType.PlainText, false,SqlConnStr);
    }

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 Sql 数据引擎, 这里只产生报表参数数据
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterReportData(System.Web.UI.Page DataPage, string ParameterQuerySQL,string SqlConnStr)
    {
        DoGenDetailData(DataPage, ParameterQuerySQL, ResponseDataType.PlainText, false,SqlConnStr);
    }

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 Sql 数据引擎, 根据RecordsetQuerySQL获取报表明细数据，根据ParameterQuerySQL获取报表参数数据
    public static void GenEntireReportData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, bool ToCompress, string SqlConnStr)
    {
        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        DataSet ReportDataSet = new DataSet();
        ReportConn.Open();
        SqlDataAdapter DataAdapter1 = new SqlDataAdapter(RecordsetQuerySQL, ReportConn);
        DataAdapter1.Fill(ReportDataSet, "Detail");
        SqlDataAdapter DataAdapter2 = new SqlDataAdapter(ParameterQuerySQL, ReportConn);
        DataAdapter2.Fill(ReportDataSet, "Master");
        ReportConn.Close();
        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  DLTSqlXMLReportData 根据SQL产生报表需要的 XML 数据，采用 Sql 数据引擎
public class DLTSqlXMLReportData : DLTSqlReportData
{
    public static void GenOneRecordset(System.Web.UI.Page DataPage, string QuerySQL,string SqlConnStr)
    {
        DLTSqlReportData.DoGenDetailData(DataPage, QuerySQL, ReportDataBase.DefaultDataType, false, SqlConnStr);
    }

    public static void GenMultiRecordset(System.Web.UI.Page DataPage, ArrayList QueryList, string SqlConnStr)
    {
        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        DataSet ReportDataSet = new DataSet();

        ReportConn.Open();

        foreach (ReportQueryItem item in QueryList)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(item.QuerySQL, ReportConn);
            DataAdapter.Fill(ReportDataSet, item.RecordsetName);
        }

        ReportConn.Close();

        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }

    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //产生报表明细记录数据，数据将被加载到明细网格的记录集中
    public static void GenDetailData(System.Web.UI.Page DataPage, string QuerySQL, string SqlConnStr)
    {
        GenOneRecordset(DataPage, QuerySQL, SqlConnStr);
    }

    //这里只产生报表参数数据，数据加载到报表参数、非明细网格中的部件框中
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterData(System.Web.UI.Page DataPage, string ParameterQuerySQL, string SqlConnStr)
    {
        GenOneRecordset(DataPage, ParameterQuerySQL, SqlConnStr);
    }

    //根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    //根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, ResponseDataType DataType,string SqlConnStr)
    {
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(RecordsetQuerySQL, "Detail"));
        QueryList.Add(new ReportQueryItem(ParameterQuerySQL, "Master"));
        GenMultiRecordset(DataPage, QueryList,SqlConnStr);
    }
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, string SqlConnStr)
    {
        GenEntireData(DataPage, RecordsetQuerySQL, ParameterQuerySQL, ReportDataBase.DefaultDataType, SqlConnStr);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  DLTSqlJsonReportData  根据SQL产生报表需要的 JSON 数据，采用 Sql 数据引擎
public class DLTSqlJsonReportData  : DLTSqlReportData
{
    public static void GenOneRecordset(System.Web.UI.Page DataPage, string QuerySQL, string SqlConnStr)
    {
        DLTSqlReportData.DoGenDetailData(DataPage, QuerySQL, ReportDataBase.DefaultDataType, true, SqlConnStr);
    }

    public static void GenMultiRecordset(System.Web.UI.Page DataPage, ArrayList QueryList, string SqlConnStr)
    {
        SqlConnection ReportConn = new SqlConnection(SqlConnStr);
        DataSet ReportDataSet = new DataSet();

        ReportConn.Open();

        foreach (ReportQueryItem item in QueryList)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(item.QuerySQL, ReportConn);
            DataAdapter.Fill(ReportDataSet, item.RecordsetName);
        }

        ReportConn.Close();

        JSONReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }


    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //产生报表明细记录数据，数据将被加载到明细网格的记录集中
    public static void GenDetailData(System.Web.UI.Page DataPage, string QuerySQL, string SqlConnStr)
    {
        GenOneRecordset(DataPage, QuerySQL, SqlConnStr);
    }

    //这里只产生报表参数数据，数据将加载到报表参数、非明细网格中的部件框中
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterData(System.Web.UI.Page DataPage, string ParameterQuerySQL, string SqlConnStr)
    {
        GenOneRecordset(DataPage, ParameterQuerySQL,SqlConnStr);
    }

    //根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    //根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, ResponseDataType DataType,string SqlConnStr)
    {
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(RecordsetQuerySQL, "Detail"));
        QueryList.Add(new ReportQueryItem(ParameterQuerySQL, "Master"));
        GenMultiRecordset(DataPage, QueryList,SqlConnStr);
    }
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, string SqlConnStr)
    {
        GenEntireData(DataPage, RecordsetQuerySQL, ParameterQuerySQL, ReportDataBase.DefaultDataType, SqlConnStr);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}