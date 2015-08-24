using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MessageBoard.Model;

namespace MessageBoard.DAL
{
    public class UserInfoDAL
    {
        //UserId,UserAccount,UserName,UserPwd,UserFlag,UserDelFlag,UserPhone

        /// <summary>
        /// 根据用户名跟用户标识从数据库中查询密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="flag">用户标识   0为普通用户    1管理员</param>
        /// <returns>UserInfo对象</returns>
        public UserInfo GetUserInfoByUserAccount(string UserAccount, int flag)
        {
            string sql = "select UserPwd,UserId,UserName from UserInfo where UserAccount=@UserAccount and UserFlag=@UserFlag and UserDelFlag=0";
            OleDbParameter[] param = { 
                                     new OleDbParameter("@UserAccount",UserAccount),
                                     new OleDbParameter ("@UserFlag",flag)
                                     };
            OleDbDataReader odr= SqlHelper.ExecuteReader(sql, param);
            UserInfo user = new UserInfo();
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    user.UserId = Convert.ToInt32(odr["UserId"]);
                    user.UserPwd = odr["UserPwd"].ToString();
                    user.UserName = odr["UserName"].ToString();
                }
            }
            return user;
        }

        /// <summary>
        /// 获取没有被删除的用户
        /// </summary>
        /// <param name="delFlag">删除标识</param>
        /// <returns>UserInfo集合</returns>
        public List< UserInfo> GetUserInfoByDelFlag(int delFlag)
        {
            string sql = "select UserId,UserName from UserInfo where  UserDelFlag=@UserDelFlag";
            OleDbDataReader odr = SqlHelper.ExecuteReader(sql, new OleDbParameter("@UserDelFlag", delFlag));
            List<UserInfo> list = new List<UserInfo>();
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    UserInfo user = new UserInfo();
                    user.UserId = Convert.ToInt32(odr["UserId"]);
                    user.UserName = odr["UserName"].ToString();
                    list.Add(user);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据用户id加载用户名称
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>包含用户名称的obj对象</returns>
        public object GetUserNameByUserId(int userId)
        {
            string sql = "select UserName from UserInfo where UserId=@UserId";
            return SqlHelper.ExecuteScalar(sql, new OleDbParameter("@UserId", userId));
        }

        /// <summary>
        /// 根据删除标识获取用户数量
        /// </summary>
        /// <param name="del">删除标识</param>
        /// <returns>用户数量</returns>
        public object GetUserCountByUserDelFlag(int del)
        {
            string sql = "select count(*) from UserInfo where UserDelFlag="+del;
            return SqlHelper.ExecuteScalar(sql);
        }

        /// <summary>
        /// 注册用户事件
        /// </summary>
        /// <param name="user">要注册用户的信息</param>
        /// <returns>受影响的行数</returns>
        public int InsertUserInfo(UserInfo user)
        {
            string sql = "insert into userinfo (UserAccount,UserName,UserPwd,UserFlag,UserDelFlag,UserPhone) values (@UserAccount,@UserName,@UserPwd,@UserFlag,@UserDelFlag,@UserPhone)";
            OleDbParameter[] param = { 
                                     new OleDbParameter("@UserAccount",user.UserAccount),
                                     new OleDbParameter("@UserName",user.UserName),
                                     new OleDbParameter("@UserPwd",user.UserPwd),
                                     new OleDbParameter("@UserFlag",user.Flag),
                                     new OleDbParameter("@UserDelFlag",user.UserDelFlag),
                                     
                                     new OleDbParameter("@UserPhone",user.UserPhone)
                                     
                                     };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        /// <summary>
        /// 根据用户提供的信息，获取用户id
        /// </summary>
        /// <param name="account">用户账号</param>
        /// <param name="name">用户名称</param>
        /// <param name="phone">练习电话</param>
        /// <returns>包括用户id的obj对象</returns>
        public object GetUserIdByAccount(string account, string name,string phone)
        {
            string sql = "select UserId from UserInfo where UserAccount=@UserAccount and UserName=@UserName and UserPhone=@UserPhone";
            OleDbParameter[] param = { 
                                     new OleDbParameter("@UserAccount",account),
                                     new OleDbParameter("@UserName",name),
                                     new OleDbParameter("@UserPhone",phone)
                                     };
            return SqlHelper.ExecuteScalar(sql, param);
        }

        /// <summary>
        /// 根据用户id修改用户密码
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="pwd">用户新密码</param>
        /// <returns>受影响的行数</returns>
        public int UpdatePwdByUserId(int userId,string pwd)
        {
            string sql = "update UserInfo set UserPwd=@UserPwd where UserId=@UsreId";
            OleDbParameter[] param={
                                   new OleDbParameter("@UserPwd",pwd),
                                   new OleDbParameter("@UsreId",userId)
                                   };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }
    }
}
