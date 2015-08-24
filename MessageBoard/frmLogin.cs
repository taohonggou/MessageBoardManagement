using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoard.Model;
using MessageBoard.BLL;

namespace MessageBoard
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        UserInfoBLL userBLL = new UserInfoBLL();
        public event EventHandler MyEvent;
        frmEventArgs fea = new frmEventArgs();
        UserLoginBLL uLoginBLL = new UserLoginBLL();
        string userLoginPwd;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadCmbUserAccount();
        }

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取用户名跟密码
            string userAccount = cmbUserAccount.Text;
            string pwd = txtPwd.Text;
            //判断用户名密码不为空
            if (CheckEmpty(userAccount, pwd))
            {
                //检测管理员单选框是否选中
                int flag = 0;
                if (ckbManager.Checked)
                {
                    flag = 1;
                }
                //将密码进行加密处理，让后与数据库中的密文进行比较
                string newPwd = Encryption(pwd);//得到加密的密码
                //从数据库中获取此用户名对象  密码  id
                UserInfo user = userBLL.GetUserInfoByUserAccount(userAccount, flag);//有密码跟ID

                if (userLoginPwd.Length > 0)
                {//从登录历史表中获得到了密码
                    newPwd = userLoginPwd;
                }
                #region 进行判断
                if (user != null)
                {
                    if (user.UserPwd == newPwd)//登录成功
                    {
                        #region 1判断登录历史中是否有这个账号  2判断CKRembPwd是否选中
                        if (uLoginBLL.CheckAccIsExist(userAccount))
                        {//存在账户
                            if (ckRemebPwd.Checked)
                            {//选中
                                //向登录历史表中插入密码 并修改时间
                                uLoginBLL.UpdatePwdAndTimeByAcc(userAccount, newPwd);
                            }
                            else
                            {//没有选中
                                //在登录历史表中清空密码，并更新时间
                                uLoginBLL.DelPwdUpdateTimeByAccount(userAccount);
                            }
                        }
                        else
                        {//不存在
                            if (ckRemebPwd.Checked)
                            {//选中
                                uLoginBLL.InsertAccountAndPwd(userAccount, newPwd);
                            }
                            else
                            {//没有选中
                                uLoginBLL.InsertUserAccount(userAccount);
                            }
                        }
                        #endregion
                        //结果一致，则显示主窗体
                        #region 将此用户id 用户名传给主窗体
                        fea.UserId = user.UserId;
                        fea.UserName = user.UserName;
                        frmMain fm = new frmMain();
                        this.MyEvent += fm.SetText;
                        if (MyEvent != null)
                        {
                            MyEvent(this, fea);
                        }

                        fm.Owner = this;
                        cmbUserAccount.Text = "";
                        txtPwd.Text = "";
                        this.Hide();//将登录窗体隐藏
                        fm.ShowDialog();
                        #endregion
                    }
                    else
                    {
                        labMsg.Text = "用户名或密码错误";
                    }
                }
                else
                {
                    labMsg.Text = "用户不存在";
                }
                #endregion

                #region 将此用户id传给主窗体
                //fea.UserId = user.UserId;
                //fea.UserName = user.UserName;
                // frmMain fm=new frmMain();
                // this.MyEvent += fm.SetText;
                // if (MyEvent!=null)
                // {
                //     MyEvent(this, fea);
                // }
                // fm.ShowDialog();
                #endregion
            }//不为空
        }//方法结束

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

        /// <summary>
        /// 判断用户名密码是否为空
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>非空true   空false</returns>
        private bool CheckEmpty(string userName, string pwd)
        {
            bool isEmpty = true;
            if (string.IsNullOrEmpty(userName))
            {
                isEmpty = false;
                labMsg.Text = "填写用户名后才能登录";
                return isEmpty;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                isEmpty = false;
                labMsg.Text = "亲，您的密码为空";
                return isEmpty;
            }
            return isEmpty;
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 注册用户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labRegister_Click(object sender, EventArgs e)
        {
            frmRegistered frmReg = new frmRegistered();
            frmReg.Owner = this;
            this.Hide();
            frmReg.ShowDialog();


        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labForgetPwd_Click(object sender, EventArgs e)
        {
            frmForgetPwd frmForget = new frmForgetPwd();
            frmForget.Owner = this;
            this.Hide();
            frmForget.ShowDialog();
        }

        /// <summary>
        /// 加载用户登录历史
        /// </summary>
        private void LoadCmbUserAccount()
        {
            List<UserLogin> list = new List<UserLogin>();
            list = uLoginBLL.GetFiveUseLogin();
            cmbUserAccount.DisplayMember = "UserAccount";
            cmbUserAccount.ValueMember = "UserPwd";
            cmbUserAccount.DataSource = list;

        }

        private void cmbUserAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            userLoginPwd = "";
            if (cmbUserAccount.SelectedValue.ToString() != "")
            {
                userLoginPwd = cmbUserAccount.SelectedValue.ToString();
                txtPwd.Text = "********";
                ckRemebPwd.Checked = true;
            }
            else
            {
                txtPwd.Text = "";
                ckRemebPwd.Checked = false;
            }
        }



    }
}
