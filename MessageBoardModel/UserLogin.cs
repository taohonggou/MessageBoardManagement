using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Model
{
    public class UserLogin
    {
        //UserLoginID,UserAccount,UserPwd,UserLoginTime

        int userLoginID;

        public int UserLoginID
        {
            get { return userLoginID; }
            set { userLoginID = value; }
        }
        string userAccount;

        public string UserAccount
        {
            get { return userAccount; }
            set { userAccount = value; }
        }
        string userPwd;

        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }

        //UserLoginTime
        DateTime userLoginTime;

        public DateTime UserLoginTime
        {
            get { return userLoginTime; }
            set { userLoginTime = value; }
        }
    }
}
