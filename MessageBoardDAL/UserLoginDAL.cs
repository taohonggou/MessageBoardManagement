using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Model;
using System.Data;
using System.Data.OleDb;

namespace MessageBoard.DAL
{
   public  class UserLoginDAL
    {
        //UserLoginID,UserAccount,UserPwd,UserLoginTime

       /// <summary>
       /// 存入用户账号
       /// </summary>
       /// <param name="userAccount">用户账号</param>
       /// <returns>受影响的行数</returns>
       public int InsertUserAccount(string userAccount)
       {
           DateTime time = DateTime.Now;
           string sql = "insert into UserLogin (UserAccount,UserLoginTime) values ('" + userAccount + "','"+time+"')";
           return SqlHelper.ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 存入用户账号 密码
       /// </summary>
       /// <param name="userAccount">户账号</param>
       /// <param name="pwd">密码</param>
       /// <returns>受影响的行数</returns>
       public int InsertAccountAndPwd(string userAccount,string pwd)
       {
           //DateTime time = DateTime.Now;
           string sql = "insert into UserLogin (UserAccount,UserPwd,UserLoginTime) values ('" + userAccount + "','" + pwd + "','" + DateTime.Now + "')";
           return SqlHelper.ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 清空用户密码
       /// </summary>
       /// <param name="userAccount">用户账号</param>
       /// <returns>受影响的行数</returns>
       public int DelPwdUpdateTimeByAccount(string userAccount)
       {
           //string sql = "update UserLogin set UserPwd='@UserPwd' , UserLoginTime='@UserLoginTime' where UserAccount='@UserAccount'";
           //OleDbParameter[] param = { 
           //                             new OleDbParameter("@UserPwd",""),
           //                          new OleDbParameter("@UserLoginTime",DateTime.Now.ToString()),
           //                         new OleDbParameter("@UserAccount",userAccount)
           //                         };
           string sql = "update UserLogin set UserPwd='' , UserLoginTime='"+DateTime.Now.ToString()+"' where UserAccount='"+userAccount+"'";

           return SqlHelper.ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 加载最近5条登录记录
       /// </summary>
       /// <returns>包含5条登录记录的list集合</returns>
       public List<UserLogin> GetFiveUseLogin()
       {
           string sql = "select top 5 * from UserLogin order by UserLoginTime desc";
           DataTable dt = SqlHelper.ExecuteTable(sql);
           List<UserLogin> list = new List<UserLogin>();

           if (dt.Rows.Count>0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   UserLogin uLogin = new UserLogin();
                   uLogin.UserAccount = dr["UserAccount"].ToString();
                   uLogin.UserPwd = dr["UserPwd"].ToString();
                   uLogin.UserLoginTime =Convert.ToDateTime( dr["UserLoginTime"]);
                   uLogin.UserLoginID =Convert.ToInt32( dr["UserLoginID"]);
                   list.Add(uLogin);
               }
           }
           return list;
       }

       /// <summary>
       /// 根据acc更新用户密码跟时间
       /// </summary>
       /// <param name="acc">登录账户</param>
       /// <param name="md5Pwd">用户密码</param>
       /// <returns>受影响的行数</returns>
       public int UpdatePwdAndTimeByAcc(string acc,string md5Pwd)
       {
           //DateTime  time = DateTime.Now;
           //string sql = "update UserLogin set UserPwd='" + md5Pwd + "' and UserLoginTime='" + DateTime.Now.ToString() + "' where UserAccount='" + acc + "'";

           string sql = "update UserLogin set UserPwd=@UserPwd , UserLoginTime=@UserLoginTime where UserAccount=@UserAccount";
           OleDbParameter[] param = { 
                                    new OleDbParameter("@UserPwd",md5Pwd),
                                    new OleDbParameter("@UserLoginTime",DateTime.Now.ToString()),
                                    new OleDbParameter("@UserAccount",acc)
                                    };
           return SqlHelper.ExecuteNonQuery(sql,param);
       }

       /// <summary>
       /// 检测给定用户是否存在
       /// </summary>
       /// <param name="acc">登录账户</param>
       /// <returns>存在标识</returns>
       public object  CheckAccIsExist(string acc)
       {
           string sql = "select count(*) from UserLogin where UserAccount=@UserAccount ";
           return SqlHelper.ExecuteScalar(sql, new OleDbParameter("@UserAccount", acc));
       }
    }
}
