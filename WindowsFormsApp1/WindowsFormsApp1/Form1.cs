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

        //создаем переменные и обьекты необходимые для подключения к базе
        MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
        MySqlConnection myConnection = new MySqlConnection();

        //добавляем данные о таблице name , cols
        TableInfo oblik = new TableInfo("Oblik","Id,PIB,Date,CameIn,ComeOut");
        TableInfo vikladachy = new TableInfo("Vikladachy","Id,PIB,Predmet,Kafedra");
        TableInfo oblikStudent = new TableInfo("Oblik_Student","PIB,_Group,SubGr,Predmet,Vykladach,Time,Data");
        TableInfo rozklad = new TableInfo("Rozklad","Kafedra,Predmet,Time,_Group,SubGr,Vykladach");
        TableInfo studenty=new TableInfo("Studenty","Id,PIB,_Group,SubGr,Kafedra,Telephone");
        
        private void Add_Tables()
        {
            //MessageBox.Show(TableInfo.count.ToString());
            string[] print = new string[TableInfo.count];
            for (int i = 0; i < TableInfo.count; i++)
            {
                print[i] =TableInfo.tables[i].name;
            }
            string[] arr= print;
            for (int i=0;i<arr.Length;i++) { }
            tableSelect.Items.AddRange(arr);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //добавляем информацию о колнках в таблице
            Add_Tables();
        }

        public void DataConnect()//присваиваем значения для подключения к серверу
        { 
            DbaseInfo dbase = new DbaseInfo("db4free.net", "oblikvykladachiv", "guy123", "guy123","cp1251",3307);
            //string server, string db, string user, string pass, uint port, string charset      
            dbase.AddTables(TableInfo.tables);
            //MessageBox.Show(dbase.Print());
            mysqlCSB.Server = dbase.Server; 
            mysqlCSB.Database = dbase.Database;    
            mysqlCSB.UserID = dbase.UserID;       
            mysqlCSB.Password = dbase.Password;   
            mysqlCSB.CharacterSet = dbase.CharacterSet;
            mysqlCSB.Port = dbase.Port;
        }

        DataTable GetData(TableInfo table)
        {
            DataTable dataTable = new DataTable();//создаем таблицу чтобы передать ей значения
            DataConnect();//присваиваем значения необходимые для подключения к базе(серверу)
            var temp = "";
            for (int i = 0; i < table.cols.Length; i++)//преобразовуем информацию о колонках в строку
            {
                var j = ", ";
                if (i == table.cols.Length - 1) { j = " "; }
                temp += table.cols[i] + j;
            }
            //создаем запрос
            string select = (@"select " + temp + " from " + table.name);
            string queryString =select;
            //MessageBox.Show(table.Print());//сообщение для отладки
            //создаем соединение и получаем значения искомой таблицы
            using (myConnection)
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

        private void tableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = tableSelect.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (tableSelect.SelectedItem.ToString() == tableSelect.Items[i].ToString())
                {
                    dataGridView1.DataSource = GetData(TableInfo.tables[i]);
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            dataGridView1.Width = Convert.ToInt32(this.Width*1);
            dataGridView1.Height = Convert.ToInt32(this.Height*0.8);
        }
    }
   
}
