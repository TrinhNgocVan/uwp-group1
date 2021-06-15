using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System.IO;
using Windows.Storage;


namespace TrinhNgocVan.Adapter
{
    class SQLiteHelper
    {
        private readonly String dbName = "exam";
        private static SQLiteHelper sQLiteHelper;
        public SQLiteConnection sQLiteConnection { get; private set; }
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
            sQLiteConnection = new SQLiteConnection(path);
            createExamTable();
          }
        public void createExamTable()
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS ExamTable(id integer primary key, name varchar(200),phoneNumber varchar(200))";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }
}
