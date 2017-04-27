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
    //класс для хранения информации о таблице
    public class TableInfo
    {
        public string name;
        public string[] cols;
        public static int count=0;
        public static TableInfo[] tables=new TableInfo[100]; //кол-во макс таблиц
        //добавляем данные о таблице name , cols
        public static TableInfo oblik = new TableInfo("Oblik", "Id,PIB,Date,CameIn,ComeOut");
        public static TableInfo vikladachy = new TableInfo("Vikladachy", "Id,PIB,Predmet,Kafedra");
        public static TableInfo oblikStudent = new TableInfo("Oblik_Student", "PIB,_Group,SubGr,Predmet,Vykladach,Time,Data");
        public static TableInfo rozklad = new TableInfo("Rozklad", "Kafedra,Predmet,Time,_Group,SubGr,Vykladach");
        public static TableInfo studenty = new TableInfo("Studenty", "Id,PIB,_Group,SubGr,Kafedra,Telephone");

        public TableInfo()
        {
            name = "unknown";
            cols = new string[] { "unknown" };
            tables[count] = this;
            count++;   
        }
        public TableInfo(string name)
        {
            this.name = name;
            cols = new string[] { "unknown" };
            tables[count] = this;
            count++;
        }
        public TableInfo(string name,string cols)
        {
            this.name = name;
            char[] sepchars = {','};
            this.cols = cols.Split(sepchars,StringSplitOptions.RemoveEmptyEntries);
            tables[count] = this;
            count++;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCols(string cols)
        {
            char[] sepchars = { ',' };
            this.cols = cols.Split(sepchars, StringSplitOptions.RemoveEmptyEntries);
        }
        static public string[] Add_Tables()
        {
            //MessageBox.Show(TableInfo.count.ToString());
            string[] print = new string[TableInfo.count];
            for (int i = 0; i < TableInfo.count; i++)
            {
                print[i] = TableInfo.tables[i].name;
            }
            string[] arr = print;
            return arr;
            //tableSelect.Items.AddRange(arr);
        }
        static public void AddToControls(ComboBox combobox,DataGridView datagrid)
        {
            //combobox.Items.AddRange(Add_Tables());
            int count = combobox.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (combobox.SelectedItem.ToString() == combobox.Items[i].ToString())
                {
                    datagrid.DataSource = DbaseInfo.dbase.GetData(TableInfo.tables[i]); 
                }
            }
        }
        public string Print()
        {
            var temp = "";
            for (int i = 0; i < this.cols.Length; i++)
            {
                var j = ", ";
                if (i == this.cols.Length - 1) { j = " "; }
                temp += this.cols[i] + j;
            }
            var print ="Name:"+this.name+"; Cols:"+temp;
            return print;
        }
    }
}
