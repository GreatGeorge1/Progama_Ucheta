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

        int tableNo;
        //создаем переменные и обьекты необходимые для подключения к базе

        string Server;// IP адрес БД
        string Database; // Имя БД
        string UserID;// Имя пользователя БД
        string Password;// Пароль пользователя БД
        string CharacterSet;// Кодировка Базы Данных
        uint Port;// Порт подключения к базе
        MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();

        //добавляем данные о таблице
        TableInfo table1 = new TableInfo("Oblik");
        string[] table1Cols = { "Id", "PIB", "Date", "CameIn", "ComeOut" };

        TableInfo table2 = new TableInfo("Vikladachy");
        string[] table2Cols = { "Id","PIB","Predmet","Kafedra"};
     

        private void Form1_Load(object sender, EventArgs e)
        {
            //добавляем информацию о колнках в таблице
            table1.SetCols(table1Cols);
            table2.SetCols(table2Cols);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetData(table1);//выводим таблицу
        }

        private void DataConnect()//присваиваем значения для подключения к серверу
        {
            Server = "db4free.net";// IP адрес БД
            Database = "oblikvykladachiv"; // Имя БД
            UserID = "guy123";// Имя пользователя БД
            Password = "guy123";// Пароль пользователя БД
            CharacterSet = "cp1251";// Кодировка Базы Данных
            Port = 3307;// Порт подключения к базе

            mysqlCSB.Server = Server; 
            mysqlCSB.Database = Database;    
            mysqlCSB.UserID = UserID;       
            mysqlCSB.Password = Password;   
            mysqlCSB.CharacterSet = CharacterSet;
            mysqlCSB.Port = Port;

        }

        DataTable GetData(TableInfo table)
        {
            DataTable dataTable = new DataTable();//создаем таблицу чтобы передать ей значения
            DataConnect();//присваиваем значения необходимые для подключения к базе(серверу)
            var temp = "";
            for (int i = 0; i < table.cols.Length; i++)//преобразовуем информацию о колнках в строку
            {
                var j = ", ";
                if (i == table.cols.Length - 1) { j = " "; }
                temp += table.cols[i] + j;

            }
            //создаем запрос
            var select = (@"select " + temp + " from " + table.name);
            string queryString =select;
            MessageBox.Show(table.Print());//сообщение для отладки
            //создаем соединение и получаем значения искомой таблицы
            using (MySqlConnection myConnection = new MySqlConnection())
            {
                myConnection.ConnectionString= mysqlCSB.ConnectionString;
                MySqlCommand myCommand = new MySqlCommand(queryString, myConnection);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "table1")
            {
                dataGridView1.DataSource = GetData(table1);//выводим таблицу
            }
            if (comboBox1.SelectedItem.ToString() == "table2")
            {
                dataGridView1.DataSource = GetData(table2);//выводим таблицу
            }
        }
    }
   
}
