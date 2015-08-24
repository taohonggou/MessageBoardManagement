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

namespace MessageBoard
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        UserInfoBLL userBLL = new UserInfoBLL();
        MessageInfoBLL mesBLL = new MessageInfoBLL();
        static  int PageNum = 0;

        public void SetText(object sender, EventArgs e)
        {
            frmEventArgs fea = e as frmEventArgs;
            
            labId.Text = fea.UserId.ToString();
           
            labName.Text = fea.UserName;
            //得到此用户的留言总数
            GetMessageCountByUserId(fea.UserId);
          
            LoadUserInfo(0);
            LoadMessageInfo(fea.UserId);
            //上一页lab不能使用
            labLastPage.ForeColor = Color.Gray;
            labLastPage.Enabled = false;
            
        }

        /// <summary>
        /// 加载所有用户到cmb中
        /// </summary>
        /// <param name="p">删除标识</param>
        private void LoadUserInfo(int p)
        {
            List<UserInfo> list = userBLL.GetUserInfoByDelFlag(p);
            list.Insert(0, new UserInfo() { UserName = "--请选择--", UserId = -1 });//这里是list添加
            cmbUser.DataSource = list;
            cmbUser.DisplayMember = "UserName";
            cmbUser.ValueMember = "UserId";
        }

        private void FirstLoadMessage(int userId)
        {
            List<MessageInfo> list = new List<MessageInfo>();
            list = mesBLL.GetLastThreeMessageByUserId(userId);
            if (list.Count < 3)
            {
                labNextPage.Enabled = false;
            }
            ShowMessageByList(list);
        }

        /// <summary>
        /// 根据用户id加载第一页留言
        /// </summary>
        /// <param name="userId">用户id</param>
        private void LoadMessageInfo(int userId)
        {
            //labMsg.Visible = false;//每次都将labMsg设置为false；
            List<MessageInfo> list = new List<MessageInfo>();
            list = mesBLL.GetLastThreeMessageByUserId(userId);
           
            //if (list.Count<3)
            //{
            //    labNextPage.Enabled = false;
            //}

            GetMessageCountByUserId(Convert.ToInt32(labId.Text));
            ShowMessageByList(list);
            
        }

        /// <summary>
        /// 根据留言集合将留言显示在group中
        /// </summary>
        /// <param name="list">留言集合</param>
        private void ShowMessageByList(List<MessageInfo> list)
        {
            if (list.Count != 0)
            {//这个用户有留言  判断返回几条留言  分别向几个分组中的lab控件赋值
                if (list.Count == 3)
                {//这里应该给三个分组都赋值
                    GetFirstGroupSetText(list[0],list.Count);
                    gbOne.Visible = true;
                    GetSecondtGroupSetText(list[1], list.Count);
                    gbTwo.Visible = true;
                    GetThirdGroupSetText(list[2], list.Count);
                    gbThree.Visible = true;
                }
                else if (list.Count == 2)
                {//给前两个赋值
                    GetFirstGroupSetText(list[0], list.Count);
                    GetSecondtGroupSetText(list[1], list.Count);
                    gbOne.Visible = true;
                    gbTwo.Visible = true;
                    gbThree.Visible = false;
                }
                else//只能等于1
                {//给最后一个group赋值
                    GetFirstGroupSetText(list[0], list.Count);
                    gbOne.Visible = true;
                    gbTwo.Visible = false;
                    gbThree.Visible = false;
                }
            }
            else//没有留言
            {
                gbOne.Visible = false;
                gbTwo.Visible = false;
                gbThree.Visible = false;
                timer1.Start();
                if (Convert.ToInt32(labMesCount.Text)==0)
                {
                    labMsg.Text = "亲，您没有收到留言，现在赶快去留言吧！";
                }
                else
                {
                    labMsg.Text = "亲，这是最后一页了";
                }
                labMsg.Visible = true;

            }
        }

        /// <summary>
        /// 跟据返回的留言信息想第三个group中添加信息
        /// </summary>
        /// <param name="messageInfo">留言详细信息</param>
        private void GetThirdGroupSetText(MessageInfo messageInfo,int count)
        {
            int userId = messageInfo.GuestUserId;
            lab3MesId.Text = messageInfo.MessageId.ToString();
            lab3GuestName.Text = GetUserNameByUserId(userId);
            lab3Content.Text = messageInfo.MessageContent;
            lab3Time.Text = messageInfo.MessageTime.ToString();

            int floorNum = 0;//PageNum == 0 && 
            if (Convert.ToInt32(labMesCount.Text) <= 3)
            {
                floorNum = count - 2;
            }
            else
            {
                floorNum = Convert.ToInt32(labMesCount.Text) - PageNum * 3-2;

            }
            lab3Floor.Text = "第" + floorNum + "楼";
        }
        /// <summary>
        /// 跟据返回的留言信息想第二个group中添加信息
        /// </summary>
        /// <param name="messageInfo">留言详细信息</param>
        private void GetSecondtGroupSetText(MessageInfo messageInfo,int count)
        {
            int userId = messageInfo.GuestUserId;
            lab2MesId.Text = messageInfo.MessageId.ToString();
            lab2GuestName.Text = GetUserNameByUserId(userId);
            lab2Content.Text = messageInfo.MessageContent;
            lab2Time.Text = messageInfo.MessageTime.ToString();

            int floorNum = 0;//PageNum == 0&&
            if (Convert.ToInt32(labMesCount.Text)<=3)
            {
                floorNum = count - 1;
            }
            else
            {
                floorNum = Convert.ToInt32(labMesCount.Text) - PageNum * 3-1;
               
            }
            lab2Floor.Text = "第" + floorNum + "楼";
        }
        /// <summary>
        /// 跟据返回的留言信息想第一个group中添加信息
        /// </summary>
        /// <param name="messageInfo">留言详细信息</param>
        private void GetFirstGroupSetText(MessageInfo messageInfo,int count)
        {
            int userId = messageInfo.GuestUserId;
            labMesId.Text = messageInfo.MessageId.ToString();
            labGuestName.Text = GetUserNameByUserId(userId);
            labContent.Text = messageInfo.MessageContent;
            labTime.Text = messageInfo.MessageTime.ToString();
            //判断PageNum是否为0
            int floorNum = 0;//PageNum == 0 && 
            if (Convert.ToInt32(labMesCount.Text) <= 3)
            {
                floorNum = count;
            }
            else
            {
                floorNum = Convert.ToInt32(labMesCount.Text) - PageNum * 3;
            }
            labFloor.Text = "第"+floorNum+"楼";
        }

        /// <summary>
        /// 根据用户id加载用户名称
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>用户名称</returns>
        public string GetUserNameByUserId(int userId)
        {
            return userBLL.GetUserNameByUserId(userId);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //LoadMessageInfo(Convert.ToInt32(labId.Text));
        }

        /// <summary>
        /// 下一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labNextPage_Click(object sender, EventArgs e)
        {
            PageNum++;
           // labMsg.Visible = false;
            timer1.Stop();

            labLastPage.Enabled = true;//点击下一页是，上一页lab可以用
            labLastPage.ForeColor = Color.Blue;
            
            List<MessageInfo> list= mesBLL.GetMessageByPageNum(PageNum, Convert.ToInt32(labId.Text));
           ShowMessageByList(list);
           if (list.Count<3)//当返回的留言总数少于3条时，禁止使用lab的点击事件
           {
               labNextPage.ForeColor = Color.Gray;
               labNextPage.Enabled = false;
               labMsg.Visible = true;
               timer1.Start();
               labMsg.Text = "这是最后一页";
               
               return;
           }
           
        }

        /// <summary>
        /// 上一页lab控件点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labLastPage_Click(object sender, EventArgs e)
        {
            PageNum--;
            timer1.Stop();

            labMsg.Visible = false;//隐藏labMsg控件
            
            labNextPage.Enabled = true;//点击上一页是，下一页lab可以用
            labNextPage.ForeColor = Color.Blue;

            List<MessageInfo> list = mesBLL.GetMessageByPageNum(PageNum, Convert.ToInt32(labId.Text));
            ShowMessageByList(list);
            if (PageNum<=0)//当PageNum在第一页时，上一页lab不能使用
            {
                labLastPage.ForeColor = Color.Gray;
                labLastPage.Enabled = false;
                labMsg.Visible = true;
                labMsg.Text = "这是第一页";
                timer1.Start();
                return;
            }
        }

        /// <summary>
        /// 每隔1.5秒就执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labMsg.Visible = false;
        }

        /// <summary>
        /// 获得到用户的留言总数，绑定到labMesCount上
        /// </summary>
        /// <param name="userId">用户id</param>
        private void GetMessageCountByUserId(int userId)
        {
            labMesCount.Text= mesBLL.GetMessageCountByUserId(userId).ToString();
        }

        /// <summary>
        /// 发表留言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublish_Click(object sender, EventArgs e)
        {
            
            if (cmbUser.SelectedIndex>=1)
            {
                //获得用户给谁留言  获得留言用户的id
                int masterUserId = Convert.ToInt32(cmbUser.SelectedValue);
                //获得用户输入的信息
                string mes = txtContent.Text;
                if (!string.IsNullOrEmpty(mes))
                {
                    //获得到当前用户的id
                    int guestUserId = Convert.ToInt32(labId.Text);
                    MessageInfo mesInfo = new MessageInfo();
                    mesInfo.GuestUserId = guestUserId;
                    mesInfo.MasterUserId = masterUserId;
                    mesInfo.MessageContent = mes;
                    mesInfo.MessageDelFlag = 0;
                    mesInfo.MessageTime = DateTime.Now;

                    string msg = mesBLL.InsertMessageInfo(mesInfo) > 0 ? "留言成功" : "留言失败";
                    txtContent.Text = "";
                    MessageBox.Show(msg);
                    //加载消息
                    LoadMessageInfo(Convert.ToInt32(labId.Text));
                }
                else
                {
                    MessageBox.Show("请输入留言内容");
                }
            }
            else
            {
                MessageBox.Show("请选择您想要留言的用户");
            }
           
        }

        /// <summary>
        /// 删除消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1DeltMesInfo_Click(object sender, EventArgs e)
        {
            //获得此消息的id
            int mesId = Convert.ToInt32(labMesId.Text);
            DeltMesInfo(mesId);
            //每次删除都需要重新获取用户的留言总数
            GetMessageCountByUserId(Convert.ToInt32(labId.Text));
            PageNum = 0;
            LoadMessageInfo(Convert.ToInt32(labId.Text));
        }
        /// <summary>
        /// 删除消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2DeltMesInfo_Click(object sender, EventArgs e)
        {
            //获得此消息的id
            int mesId = Convert.ToInt32(lab2MesId.Text);
            DeltMesInfo(mesId);

            //每次删除都需要重新获取用户的留言总数
            GetMessageCountByUserId(Convert.ToInt32(labId.Text));
            PageNum = 0;
            LoadMessageInfo(Convert.ToInt32(labId.Text));
        }
        /// <summary>
        /// 删除消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3DeltMesInfo_Click(object sender, EventArgs e)
        {
            //获得此消息的id
            int mesId = Convert.ToInt32(lab3MesId.Text);
            DeltMesInfo(mesId);

            //每次删除都需要重新获取用户的留言总数
            GetMessageCountByUserId(Convert.ToInt32(labId.Text));
            PageNum = 0;
            LoadMessageInfo(Convert.ToInt32(labId.Text));
        }

        /// <summary>
        /// 根据消息id删除消息
        /// </summary>
        /// <param name="mesId">消息id</param>
        private void DeltMesInfo(int mesId)
        {
            string msg = mesBLL.DeltMesInoByMesId(mesId);
            MessageBox.Show(msg);
        }

        private void lab1Reply_Click(object sender, EventArgs e)
        {
            //留言人的id，获取留言内容 
            string content = labContent.Text;
            int MesId=Convert.ToInt32( labMesId.Text);
            //根据消息id获取留言人id
            int guestId = mesBLL.GetGuestIdByMesId(MesId);
            //将cmb选中此留言人   向txtmsg中加入  回复：留言人 留言信息
            cmbUser.SelectedValue = guestId;
            txtContent.Text = "回复：" + content;

        }

        private void lab2Reply_Click(object sender, EventArgs e)
        {
            //留言人的id，获取留言内容 
            string content = lab2Content.Text;
            int MesId=Convert.ToInt32( lab2MesId.Text);
            //根据消息id获取留言人id
            int guestId = mesBLL.GetGuestIdByMesId(MesId);
            //将cmb选中此留言人   向txtmsg中加入  回复：留言人 留言信息
            cmbUser.SelectedValue = guestId;
            txtContent.Text = "回复：" + content;
        }

        private void lab3Reply_Click(object sender, EventArgs e)
        {
            //留言人的id，获取留言内容 
            string content = lab3Content.Text;
            int MesId = Convert.ToInt32(lab3MesId.Text);
            //根据消息id获取留言人id
            int guestId = mesBLL.GetGuestIdByMesId(MesId);
            //将cmb选中此留言人   向txtmsg中加入  回复：留言人 留言信息
            cmbUser.SelectedValue = guestId;
            txtContent.Text = "回复：" + content;
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
