using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoard.Model;
using MessageBoard.BLL;
using System.Security.Cryptography;

namespace MessageBoard
{
    public partial class frmRegistered : Form
    {
        public frmRegistered()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            UserInfo userNew = new UserInfo();
            userNew.UserName = txtName.Text;

            userNew.UserPwd =Encryption(txtPsw.Text);
            userNew.UserPhone = txtPho.Text;
            userNew.Flag = 0;
            userNew.UserDelFlag = 0;
            //给UserAccount赋值 由于UserAccount不能设置为自动增长，随机数又的检测重复，所以我再次只获取用户的数量，根据用户数量给用户设置登录账号
            UserInfoBLL userBLL = new UserInfoBLL();
            int userCount = userBLL.GetUserCountByUserDelFlag(0);
            userNew.UserAccount = GetUserAccountByUserCount(userCount);
            int msg = userBLL.InsertUserInfo(userNew);//1成功   0失败
            //查看是否注册成功 成功：给用户返回登录账号，关闭注册窗体   失败：显示直接停留在注册窗体
            if (msg==1)
            {
                MessageBox.Show("注册成功，请牢记您的登录账号：" + userNew.UserAccount);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败，请重新注册");
                txtName.Text = "";
                txtPho.Text = "";
                txtPsw.Text = "";
            }
        }

        /// <summary>
        /// 根据用户传入的用户总数，得到新的用户账号
        /// </summary>
        /// <param name="userCount">用户总数</param>
        /// <returns>用户账号</returns>
        private string GetUserAccountByUserCount(int userCount)
        {
            int length = userCount.ToString().Length;
            string userAccount = null;
            switch (length)
            {
                case 1:
                    userAccount = "000" + (userCount + 1).ToString();
                    break;
                case 2:
                    userAccount = "00" + (userCount + 1).ToString();
                    break;
                case 3:
                    userAccount = "0" + (userCount + 1).ToString();
                    break;
                default:
                    userAccount = (userCount + 1).ToString();
                    break;
            }
            return userAccount;
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








        private void frmRegistered_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
