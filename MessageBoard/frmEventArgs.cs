using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard
{
    public class frmEventArgs : EventArgs
    {
        int userId;
        /// <summary>
        /// 用来存放用户ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        string userName;
        /// <summary>
        /// 用来存放用户名称
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
