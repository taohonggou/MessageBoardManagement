using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoard.BLL;
using MessageBoard.Model;

namespace MessageBoard
{
    public partial class frmForgetPwd : Form
    {
        public frmForgetPwd()
        {
            InitializeComponent();
        }

        private void frmForgetPwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //获取输入内容
            string account = txtAccount.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            //根据输入的内容，在数据库中查找有没有这条记录，有的话返回用户的id，修改密码（随机生成）
            UserInfoBLL userBLL = new UserInfoBLL();
            string msg = userBLL.UpdatePwd(account, name, phone);
            MessageBox.Show(msg);
            txtPhone.Text = "";
            txtName.Text = "";
            txtAccount.Text = "";
        }
    }
}
