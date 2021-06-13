using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom1.Dao;
using Nhom1.Adapters;
using Nhom1.Models;
using SQLitePCL;

namespace Nhom1.Dao.Impl
{
    class OrderHistoryImpl : OrderHistoryDao
    {
        public bool AddToOrderHistory(OrderHistory item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "insert into OrderHistory(id,orderId,time) values(?,?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            statement.Bind(2, item.orderId);
            statement.Bind(3, item.time);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

     
        public List<OrderHistory> getOrderHistory()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "select * from OrderHistory";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<OrderHistory> list = new List<OrderHistory>();
            while (SQLiteResult.ROW == statement.Step())
            {
                int id = Convert.ToInt32(statement[0]);
                string orderId = (string)statement[1];
                string time = (string)statement[2];
                OrderHistory c = new OrderHistory(id, orderId,time);
                list.Add(c);
            }
            return list;
        }

      
    }
}
