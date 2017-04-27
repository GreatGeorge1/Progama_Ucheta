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

        private void Form1_Load(object sender, EventArgs e)
        {
            //добавляем информацию о колнках в таблице
            tableSelect.Items.AddRange(TableInfo.Add_Tables());   
        }

        private void tableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableInfo.AddToControls(tableSelect,dataGridView1,textBox1);  
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            dataGridView1.Width = Convert.ToInt32(this.Width*1);
            dataGridView1.Height = Convert.ToInt32(this.Height*0.8);
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            dataGridView1.Width = Convert.ToInt32(this.Width * 1);
            dataGridView1.Height = Convert.ToInt32(this.Height * 0.8);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = Convert.ToInt32(this.Width * 1);
            dataGridView1.Height = Convert.ToInt32(this.Height * 0.8);
        }

        private void search_Click(object sender, EventArgs e)
        {
            TableInfo.AddToControls(tableSelect, dataGridView1, textBox1, search);
        }
    }
   
}
