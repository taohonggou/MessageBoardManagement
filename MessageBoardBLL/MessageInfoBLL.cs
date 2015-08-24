using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.DAL;
using MessageBoard.Model;

namespace MessageBoard.BLL
{
   public  class MessageInfoBLL
    {
       MessageInfoDAL messDAL = new MessageInfoDAL();

        /// <summary>
        /// 根据用户传来的id，返回在此id下的最近三条留言
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>MessageInfo集合</returns>
        public List<MessageInfo> GetLastThreeMessageByUserId(int userId)
       {
           return messDAL.GetLastThreeMessageByUserId(userId);
       }
        
        /// <summary>
        /// 根据用户id和以经显示的条数，来查找将要显示的消息
        /// </summary>
        /// <param name="topNum">以经显示的条数</param>
        /// <param name="userId">用户id</param>
        /// <returns>将要显示的消息</returns>
        public List<MessageInfo> GetMessageByPageNum(int pageNum,int userId)
        {
            return messDAL.GetMessageByPageNum(pageNum * 3, userId);
        }

        /// <summary>
        /// 根据用户id获取用户的所有留言
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>此用户的留言总数</returns>
        public int GetMessageCountByUserId(int userId)
        {
            return Convert.ToInt32(messDAL.GetMessageCountByUserId(userId));
        }

        /// <summary>
        /// 向数据库中插入一条留言
        /// </summary>
        /// <param name="mesInfo">留言信息</param>
        /// <returns>受影响的行数</returns>
        public int InsertMessageInfo(MessageInfo mesInfo)
        {
            return messDAL.InsertMessageInfo(mesInfo);
        }

        /// <summary>
        /// 根据消息id删除消息
        /// </summary>
        /// <param name="mesId">消息</param>
        /// <returns>删除成功与否</returns>
        public string  DeltMesInoByMesId(int mesId)
        {
            return messDAL.DeltMesInoByMesId(mesId) > 0 ? "删除成功" : "删除失败";
        }

       /// <summary>
        /// 根据消息id返回留言人id
        /// </summary>
        /// <param name="mesId">消息id</param>
        /// <returns>留言人id</returns>
        public int GetGuestIdByMesId(int mesId)
        {
            return Convert.ToInt32(messDAL.GetGuestIdByMesId(mesId));
        }
    }
}
