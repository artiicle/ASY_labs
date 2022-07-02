using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager
{
    class Database
    {
        private SQLiteConnection db;
        private readonly string db_path = "D:\\lp.db";
        public bool IsOpened = false;

        public void init()
        {
            SQLiteConnectionString options = new SQLiteConnectionString(db_path, false, "password", postKeyAction: c => {
                // c.Execute("PRAGMA cipher_compatibility = 3");
            });
            db = new SQLiteConnection(options);
            db.Execute("create table Record (id INTEGER PRIMARY KEY NOT NULL, url varchar(40), login varchar(80), password varchar(80))");
            IsOpened = true;
        }

        internal void testRec(Record record)
        {
            db.CreateTable<Record>();
        }

        public List<Record> getRecords()
        {
            List<Record> records = db.Query<Record>("select * from Record;");
            return records;
        }

        internal void newRecord(string url, string encLogin, string encPass)
        {
            db.Execute($"insert into Record (url, login, password) values ('{url}', '{encLogin}', '{encPass}')");
        }

        internal void deleteRecord(string id)
        {
            db.Execute($"delete from Record where id == {id}");
        }

        internal void reIndexTable()
        {
            db.Execute($"reindex Record");
        }

        internal void open()
        {
            SQLiteConnectionString options = new SQLiteConnectionString(db_path, false, "password", postKeyAction: c => {
                // c.Execute("PRAGMA cipher_compatibility = 3");
            });
            db = new SQLiteConnection(options);
            IsOpened = true;
        }

        internal void close()
        {
            db.Close();
            db.Dispose();
            IsOpened = false;
        }

        internal List<Record> getAllTable()
        {
            List<Record> record = db.Query<Record>("select * from record");

            return record;
        }

        

        internal Record getRecord(string id)
        {
            Record record = db.Query<Record>($"select * from Record where id=={id}")[0];
            return record;
        }
    }

    [Table("Record")]
    class Record
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string url { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public Record() { }
    }
}
