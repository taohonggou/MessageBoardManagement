using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using  System.Data.OleDb;
using System.Data;

namespace MessageBoard.DAL
{
    public class SqlHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>受影响的行数</returns>
        public static  int ExecuteNonQuery(string sql, params OleDbParameter[] param)
        {
            using(OleDbConnection con=new OleDbConnection(conStr))
            {
                using(OleDbCommand cmd=new OleDbCommand(sql,con))
                {
                    con.Open();
                    if (param!=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    int i=cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }

       

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>包含结果信息的首行首列</returns>
        public static  object ExecuteScalar(string sql, params OleDbParameter[] param)
        {
            using(OleDbConnection con=new OleDbConnection(conStr))
            {
                using(OleDbCommand cmd=new OleDbCommand(sql,con))
                {
                    con.Open();
                    if (param!=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 用来做查询，返回的是一行一行的
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>返回SQLiteDataReader</returns>
        public static  OleDbDataReader  ExecuteReader(string sql, params OleDbParameter[] param)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            using (OleDbCommand cmd=new OleDbCommand(sql,con))
            {
                con.Open();
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    con.Close();
                    con.Dispose();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 返回一个表的数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteTable(string sql,params OleDbParameter [] param)
        {
            DataTable dt = new DataTable();
            using (OleDbDataAdapter oda=new OleDbDataAdapter(sql,conStr) )
            {
                if (param!=null)
                {
                    oda.SelectCommand.Parameters.AddRange(param);
                }
                oda.Fill(dt);
            }
            return dt;
        }
    }
}
