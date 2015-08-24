using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Model;
using MessageBoard.DAL;

namespace MessageBoard.BLL
{
    public  class UserLoginBLL
    {
        //UserLoginID,UserAccount,UserPwd

        UserLoginDAL loginDAL=new UserLoginDAL();

        /// <summary>
       /// 存入用户账号
       /// </summary>
       /// <param name="userAccount">用户账号</param>
       /// <returns>受影响的行数</returns>
       public int InsertUserAccount(string userAccount)
       {
           return loginDAL.InsertUserAccount(userAccount);
       }

        /// <summary>
       /// 存入用户账号 密码
       /// </summary>
       /// <param name="userAccount">户账号</param>
       /// <param name="pwd">密码</param>
       /// <returns>受影响的行数</returns>
       public int InsertAccountAndPwd(string userAccount,string pwd)
       {
           return loginDAL.InsertAccountAndPwd(userAccount,pwd);
       }

        /// <summary>
       /// 清空用户密码并更新时间
       /// </summary>
       /// <param name="userAccount">用户账号</param>
       /// <returns>受影响的行数</returns>
       public bool DelPwdUpdateTimeByAccount(string userAccount)
       {
           return loginDAL.DelPwdUpdateTimeByAccount(userAccount)>0?true:false;
       }

       /// <summary>
       /// 加载最近5条登录记录
       /// </summary>
       /// <returns>包含5条登录记录的list集合</returns>
        public List<UserLogin> GetFiveUseLogin()
        {
            return loginDAL.GetFiveUseLogin();
        }

         /// <summary>
       /// 根据acc更新用户密码跟时间
       /// </summary>
       /// <param name="acc">登录账户</param>
       /// <param name="md5Pwd">用户密码</param>
       /// <returns>true成功   false失败</returns>
       public bool UpdatePwdAndTimeByAcc(string acc,string md5Pwd)
        {
            return loginDAL.UpdatePwdAndTimeByAcc(acc, md5Pwd) > 0 ? true : false;
        }

        /// <summary>
       /// 检测给定用户是否存在
       /// </summary>
       /// <param name="acc">登录账户</param>
       /// <returns>存在标识</returns>
       public bool  CheckAccIsExist(string acc)
       {
           return Convert.ToInt32( loginDAL.CheckAccIsExist(acc)) > 0 ? true : false;
       }
    }
}
