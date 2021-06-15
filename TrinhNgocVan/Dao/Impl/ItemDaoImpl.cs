using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinhNgocVan.Models;
using TrinhNgocVan.Dao;
using TrinhNgocVan.Adapter;
using SQLitePCL;

namespace TrinhNgocVan.Dao.Impl
{
    class ItemDaoImpl : ItemDao
    {
        public bool AddToListItem(Item item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "insert into ExamTable(id,name,phoneNumber) values(?,?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            statement.Bind(2, item.name);
            statement.Bind(3, item.phoneNumber);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

        public bool CheckItemExist(Item item)
        {
            throw new NotImplementedException();
        }

        public bool ClearAllItem()
        {
            throw new NotImplementedException();
        }

        public List<Item> GetListItem()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "select * from ExamTable";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<Item> list = new List<Item>();
            while (SQLiteResult.ROW == statement.Step())
            {
                int id = Convert.ToInt32(statement[0]);
                string name = (string)statement[1];
                string phoneNumber = (string)statement[2];
                Item c = new Item(id, name,phoneNumber);
                list.Add(c);
            }
            return list;
        }

        public bool RemoveItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Item searchItemByName(Item item)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
