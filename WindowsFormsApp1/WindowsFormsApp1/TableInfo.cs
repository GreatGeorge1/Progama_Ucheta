using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //класс для хранения информации о таблице
    public class TableInfo
    {
        public string name;
        public string[] cols;

        public TableInfo()
        {
            name = "unknown";
        }

        public TableInfo(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetCols(string[] cols)
        {
            this.cols = cols;
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
