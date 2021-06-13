using Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom1.Adapters;
using SQLitePCL;
namespace Nhom1.Dao.Impl
{
    class FavorteList : FavoriteFoodSerivce
    {   
           public bool checkItemExist(CartItem checkItem)
        {
            bool result = false;
            List<CartItem> lsCarts = GetFavoriteList();
            foreach(CartItem item in lsCarts)
            {
                if(item.id == checkItem.id)
                {
                    result = true; break;
                }
            }
            return result;
        }
        public bool AddToFavoriteList(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "insert into FavoriteList (id,name,image,price,qty) values(?,?,?,?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            statement.Bind(2, item.name);
            statement.Bind(3, item.image);
            statement.Bind(4, item.price);
            statement.Bind(5, item.qty);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

        public bool ClearFavoriteList()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetFavoriteList()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "select * from FavoriteList";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<CartItem> list = new List<CartItem>();
            while (SQLiteResult.ROW == statement.Step())
            {
                int id = Convert.ToInt32(statement[0]);
                string name = (string)statement[1];
                string image = (string)statement[2];
                int price = Convert.ToInt32(statement[3]);
                int qty = Convert.ToInt32(statement[4]);
                CartItem c = new CartItem(id, name, image, price, qty);
                list.Add(c);
            }
            return list;
        }

        public bool RemoveFavoriteList(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "delete from FavoriteList  where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

        public bool UpdateFavoriteList(CartItem item, int qty)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "update FavoriteList  set qty = ? where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, qty);
            statement.Bind(2, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
    }
}
