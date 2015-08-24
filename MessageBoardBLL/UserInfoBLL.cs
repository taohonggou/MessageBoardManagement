using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Model;
using MessageBoard.DAL;
using System.Security.Cryptography;

namespace MessageBoard.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL userDAL = new UserInfoDAL();

         /// <summary>
        /// 根据用户名跟用户标识从数据库中查询密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="flag">用户标识   0为普通用户    1管理员</param>
        /// <param name="md5Pwd">密码</param>
        /// <param name="msg">反馈消息</param>
        /// <returns>是否登录成功</returns>
        public UserInfo  GetUserInfoByUserAccount(string userAccount,int flag)
        {
            return userDAL.GetUserInfoByUserAccount(userAccount, flag);
        }

          /// <summary>
        /// 获取没有被删除的用户
        /// </summary>
        /// <param name="delFlag">删除标识</param>
        /// <returns>UserInfo集合</returns>
        public List< UserInfo> GetUserInfoByDelFlag(int delFlag)
        {
            return userDAL.GetUserInfoByDelFlag(delFlag);
        }

        /// <summary>
        /// 根据用户id加载用户名称
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>用户名称</returns>
        public string GetUserNameByUserId(int userId)
        {
            return userDAL.GetUserNameByUserId(userId).ToString();
        }

         /// <summary>
        /// 根据删除标识获取用户数量
        /// </summary>
        /// <param name="del">删除标识</param>
        /// <returns>用户数量</returns>
        public int GetUserCountByUserDelFlag(int del)
        {
            return Convert.ToInt32( userDAL.GetUserCountByUserDelFlag(del));
        }

        /// <summary>
        /// 注册用户事件
        /// </summary>
        /// <param name="user">要注册用户的信息</param>
        /// <returns>注册结果 1成功   0失败</returns>
        public int InsertUserInfo(UserInfo user)
        {
            return userDAL.InsertUserInfo(user);
        }


        public string UpdatePwd(string account,string name,string phone)
        {
            object obj= userDAL.GetUserIdByAccount(account, name, phone);
            if (obj!=null)
            {
                int userId = Convert.ToInt32(obj);
                //随机生成新密码
                Random r = new Random();
                string  Pwd= r.Next(1, 999).ToString();
                string endPwd = Encryption(Pwd);
                //根据用户id更新密码
                int i = userDAL.UpdatePwdByUserId(userId, endPwd);
                if (i==1)
                {
                    return "修改成功，您的新密码为" + Pwd + "请牢记";
                }
                else
                {
                    return "修改失败";
                }
            }
            else
            {
                return "输入信息有误";
            }

        }

        /// <summary>
        /// 将传入的密码进行MD5加密
        /// </summary>
        /// <param name="pwd">原密码</param>
        /// <returns>加密后的密码</returns>
        public string Encryption(string pwd)
        {
            MD5 md5 = MD5.Create();//
            byte[] pwdBuffer = System.Text.Encoding.Default.GetBytes(pwd);
            byte[] newPwdBuffer = md5.ComputeHash(pwdBuffer);
            string newPwd = "";
            foreach (byte item in newPwdBuffer)
            {
                newPwd += item.ToString("x2");
            }
            return newPwd;
        }

    }
}
