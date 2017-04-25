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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
          //  mysqlCSB.Server = "db4free.net";  // IP адоес БД
          //  mysqlCSB.Database = "oblikvykladachiv";    // Имя БД
          //  mysqlCSB.UserID = "guy123";        // Имя пользователя БД
          //  mysqlCSB.Password = "guy123";   // Пароль пользователя БД
          //  mysqlCSB.CharacterSet = "cp1251"; // Кодировка Базы Данных
          //  MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);


           // try
           // {
           //     myConnection.Open(); // Открываем соединение
           //                          // --- код запроса и т.п. --- //
            //    MessageBox.Show("Подключение прошло успешно!");
          //     // myConnection.Close(); // Закрываем соединение
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message, "Ошибка");
           // }

            dataGridView1.DataSource = GetComments();
            //myConnection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        DataTable GetComments()
        {
            DataTable dt = new DataTable();
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "db4free.net";  // IP адрес БД
            mysqlCSB.Database = "oblikvykladachiv";    // Имя БД
            mysqlCSB.UserID = "guy123";        // Имя пользователя БД
            mysqlCSB.Password = "guy123";   // Пароль пользователя БД
            mysqlCSB.CharacterSet = "cp1251"; // Кодировка Базы Данных
            mysqlCSB.Port = 3307;
            string queryString = @"
            SELECT Id,
            PIB,Date,CameIn,ComeOut
            FROM   Oblik;";
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(queryString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }
    }
}
