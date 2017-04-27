using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    class DbaseInfo
    {
        string Server;// IP адрес БД
        string Database; // Имя БД
        string UserID;// Имя пользователя БД
        string Password;// Пароль пользователя БД
        string CharacterSet;// Кодировка Базы Данных
        uint Port;// Порт подключения к базе   
        public TableInfo[] tables;
        //public static MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
        public static MySqlConnection myConnection = new MySqlConnection();
        MySqlCommand myCommand = new MySqlCommand();
        public static DbaseInfo dbase = new DbaseInfo("db4free.net", "oblikvykladachiv", "guy123", "guy123", "cp1251", 3307);

        public DbaseInfo()
        {
            this.Server = "Server";
            this.Database = "Database";
            this.UserID = "UserID";
            this.Password = "Password";
        }
        public DbaseInfo(string server, string db, string user, string pass)
        {
            this.Server = server;
            this.Database = db;
            this.UserID = user;
            this.Password = pass;
        }
        public DbaseInfo(string server, string db, string user, string pass, string charset,uint port)
        {
            this.Server = server;
            this.Database = db;
            this.UserID = user;
            this.Password = pass;
            this.Port = port;
            this.CharacterSet = charset;
        }
        public void AddTables(TableInfo[] tables)
        {
            this.tables =tables;
        }
        public string Print()
        {
            string print = "";
            foreach (TableInfo element in tables)
            {
                if (element != null) // Avoid NullReferenceException
                {
                    
                    print +=element.name+" ";
                }
            }
            return print;
        }
        public MySqlConnectionStringBuilder DataConnect()//присваиваем значения для подключения к серверу
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = dbase.Server;
            mysqlCSB.Database = dbase.Database;
            mysqlCSB.UserID = dbase.UserID;
            mysqlCSB.Password = dbase.Password;
            mysqlCSB.CharacterSet = dbase.CharacterSet;
            mysqlCSB.Port = dbase.Port;
            return mysqlCSB;
        }
        public DataTable GetData(TableInfo table)
        {
            DataTable dataTable = new DataTable();//создаем таблицу чтобы передать ей значения
               //присваиваем значения необходимые для подключения к базе(серверу)
            AddTables(TableInfo.tables);
            var temp = "";
            for (int i = 0; i < table.cols.Length; i++)//преобразовуем информацию о колонках в строку
            {
                var j = ", ";
                if (i == table.cols.Length - 1) { j = " "; }
                temp += table.cols[i] + j;
            }
            //создаем запрос
            string select = (@"select " + temp + " from " + table.name);
            string queryString = select;
            //MessageBox.Show(table.Print());//сообщение для отладки
            //создаем соединение и получаем значения искомой таблицы
            using (myConnection)
            {
                myConnection.ConnectionString = dbase.DataConnect().ConnectionString;
                myCommand.CommandText =queryString;
                myCommand.Connection = myConnection;
                try
                {
                    myConnection.Open();
                    using (MySqlDataReader dataReader = myCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataTable.Load(dataReader);
                        }
                    }
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dataTable;//получаем готовую таблицу
        }
    }
}
