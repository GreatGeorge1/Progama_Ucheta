using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
