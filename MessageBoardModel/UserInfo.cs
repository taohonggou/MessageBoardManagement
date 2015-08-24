using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Model
{
   public  class UserInfo
    {
        //UserId UserAccount UserName  UserPwd UserFlag UserDelFlag UserPhone
        int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        string userAccount;

        public string UserAccount
        {
            get { return userAccount; }
            set { userAccount = value; }
        }

       string userName;

       public string UserName
       {
           get { return userName; }
           set { userName = value; }
       }
       string userPwd;

       public string UserPwd
       {
           get { return userPwd; }
           set { userPwd = value; }
       }
       int flag;

       public int Flag
       {
           get { return flag; }
           set { flag = value; }
       }
       int userDelFlag;

       public int UserDelFlag
       {
           get { return userDelFlag; }
           set { userDelFlag = value; }
       }
       string userPhone;

       public string UserPhone
       {
           get { return userPhone; }
           set { userPhone = value; }
       }
    }
}
