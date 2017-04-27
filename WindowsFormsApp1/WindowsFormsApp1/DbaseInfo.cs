using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp1
{
    class DbaseInfo
    {
        public string Server;// IP адрес БД
        public string Database; // Имя БД
        public string UserID;// Имя пользователя БД
        public string Password;// Пароль пользователя БД
        public string CharacterSet;// Кодировка Базы Данных
        public uint Port;// Порт подключения к базе   
        public TableInfo[] tables;

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

    }
}
