using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System.IO;
using Windows.Storage;

namespace Nhom1.Adapters
{
    class SQLiteHelper
    {
        private readonly string dbName = "t2004e";

        private static SQLiteHelper sQLiteHelper;

        public static SQLiteHelper GetInstance()
        {
            if (sQLiteHelper == null)
            {
                sQLiteHelper = new SQLiteHelper();
            }
            return sQLiteHelper;
        }

        private SQLiteHelper()
        {
            string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, dbName);
            sQLiteConnection = new SQLiteConnection(path); // tao db - để tên db cũng được
            CreateCartTable();
            CreateFavoriteTable();
            CreateOrderHistoryTable();
        }

        public SQLiteConnection sQLiteConnection { get; private set; }

        public void CreateCartTable() // tao bang cart
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS Cart(id integer primary key, name varchar(200), image varchar(200), price integer, qty integer)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
        public void CreateFavoriteTable() // tao bang cart
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS FavoriteList(id integer primary key, name varchar(200), image varchar(200), price integer, qty integer)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
        public void CreateOrderHistoryTable() // tao bang cart
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS OrderHistory(id integer primary key, orderId varchar(200),time varchar(200))";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }

}
