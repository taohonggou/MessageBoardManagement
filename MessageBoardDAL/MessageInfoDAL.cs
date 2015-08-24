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
    public class MessageInfoDAL
    {
        //MessageId,MasterUserId,GuestUserId,MessageContent,MessageTime,MessageDelFlag

        /// <summary>
        /// 根据用户传来的id，返回在此id下的最近三条留言
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>MessageInfo集合</returns>
        public List<MessageInfo> GetLastThreeMessageByUserId(int userId)
        {
            string sql = "select top 3 * from MessageInfo where MasterUserId=@MasterUserId and MessageDelFlag=0  order by MessageTime DESC";//根据MessageId进行降序排序
            DataTable dt = SqlHelper.ExecuteTable(sql, new OleDbParameter("@MasterUserId", userId));
            List<MessageInfo> list = new List<MessageInfo>();

            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    MessageInfo message = new MessageInfo();
                    message.GuestUserId = Convert.ToInt32(dr["GuestUserId"]);
                    message.MasterUserId = Convert.ToInt32(dr["MasterUserId"]);
                    message.MessageContent = dr["MessageContent"].ToString();
                    message.MessageId = Convert.ToInt32(dr["MessageId"]);
                    message.MessageTime = Convert.ToDateTime(dr["MessageTime"]);
                    list.Add(message);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据用户id和以经显示的条数，来查找将要显示的消息
        /// </summary>
        /// <param name="topNum">以经显示的条数</param>
        /// <param name="userId">用户id</param>
        /// <returns>将要显示的消息</returns>
        public List<MessageInfo> GetMessageByPageNum(int topNum,int userId)
        {
            string sql = null;
            if (topNum>0)
            {
                sql = "select top 3 MessageId,MasterUserId,GuestUserId,MessageContent,MessageTime from [select * from messageinfo where MasterUserId=@MasterUserId and MessageDelFlag=0 order by messagetime desc ]. as a where messageid not in (select top " + topNum + " messageid from messageinfo where MasterUserId=@mUserId and MessageDelFlag=0 order by messagetime desc ) ";
            }
            else
            {
                sql = "select top 3 MessageId,MasterUserId,GuestUserId,MessageContent,MessageTime from MessageInfo where  MasterUserId=@MasterUserId and MessageDelFlag=0 order by MessageTime desc";
            }

            OleDbParameter[] param = { 
                                     new OleDbParameter("@MasterUserId",userId),
                                     new OleDbParameter("@mUserId",userId)
                                     
                                     };
            List<MessageInfo> list = new List<MessageInfo>();
            DataTable dt=SqlHelper.ExecuteTable(sql,param);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    MessageInfo mes = new MessageInfo();
                    mes = RowToMessageInfo(dr);
                    list.Add(mes);
                }
            }
            return list;
        }

        /// <summary>
        /// 将messageinfo行转换为messageInfo对象
        /// </summary>
        /// <param name="dr">messageinfo行</param>
        /// <returns>messageInfo对象</returns>
        private MessageInfo RowToMessageInfo(DataRow dr)
        {
            MessageInfo mes = new MessageInfo();
            mes.GuestUserId = Convert.ToInt32(dr["GuestUserId"]);
            mes.MasterUserId = Convert.ToInt32(dr["MasterUserId"]);
            //mes.MessageDelFlag = Convert.ToInt32(dr["MessageDelFlag"]);
            mes.MessageId = Convert.ToInt32(dr["MessageId"]);
            mes.MessageTime = Convert.ToDateTime(dr["MessageTime"]);
            mes.MessageContent = dr["MessageContent"].ToString();
            return mes;
        }

        /// <summary>
        /// 根据用户id获取用户的所有留言
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>包含留言总数的obj对象</returns>
        public object GetMessageCountByUserId(int userId)
        {
            string sql = "select Count(*) from MessageInfo where MasterUserId=@MasterUserId and MessageDelFlag=0";
            return SqlHelper.ExecuteScalar(sql, new OleDbParameter("@MasterUserId", userId));
        }

        /// <summary>
        /// 向数据库中插入一条留言
        /// </summary>
        /// <param name="mesInfo">留言信息</param>
        /// <returns>受影响的行数</returns>
        public int InsertMessageInfo(MessageInfo mesInfo)
        {
           // string sql = "insert into MessageInfo (MasterUserId,GuestUserId,MessageContent,MessageTime,MessageDelFlag) values (@MasterUserId,@GuestUserId,@MessageContent,@MessageTime,@MessageDelFlag)";
            string sql = "insert into MessageInfo (MasterUserId,GuestUserId,MessageContent,MessageTime,MessageDelFlag) values (" + mesInfo.MasterUserId + "," + mesInfo.GuestUserId + ",'" + mesInfo.MessageContent + "','" + mesInfo.MessageTime + "'," + mesInfo.MessageDelFlag + ")";
            //OleDbParameter[] param = { 
            //                         new OleDbParameter("@MasterUserId",mesInfo.MasterUserId),
            //                         new OleDbParameter("@GuestUserId",mesInfo.GuestUserId),
            //                         new OleDbParameter("@MessageContent",mesInfo.MessageContent),
            //                         new OleDbParameter("@MessageTime",mesInfo.MessageTime),
            //                         new OleDbParameter("@MessageDelFlag",mesInfo.MessageDelFlag)
            //                         };
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据消息id删除消息
        /// </summary>
        /// <param name="mesId">消息</param>
        /// <returns>受影响的行数</returns>
        public int DeltMesInoByMesId(int mesId)
        {
            string sql = "update MessageInfo set MessageDelFlag=1 where MessageId=@MessageId";
            return SqlHelper.ExecuteNonQuery(sql,new OleDbParameter("@MessageId",mesId));
        }

        /// <summary>
        /// 根据消息id返回留言人id
        /// </summary>
        /// <param name="mesId">消息id</param>
        /// <returns>包含留言人id的obj</returns>
        public object GetGuestIdByMesId(int mesId)
        {
            string sql = "select GuestUserId from MessageInfo where MessageId=@MessageId";
            return SqlHelper.ExecuteScalar(sql, new OleDbParameter("@MessageId", mesId));
        }
    }
}
