using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Star405 : Form
    {
        public Star405()
        {
            InitializeComponent();
        }
        public System.Data.SqlClient.SqlCommand UpdateCommand { get; set; }
        private void Star405_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "anketDataSet5.Table_4". При необходимости она может быть перемещена или удалена.
            this.table_4TableAdapter3.Fill(this.anketDataSet5.Table_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "anketDataSet4.Table_4". При необходимости она может быть перемещена или удалена.
            this.table_4TableAdapter2.Fill(this.anketDataSet4.Table_4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_4TableAdapter3.Update(this.anketDataSet5);
          //  listBox1.Items.Add(dataGridView1.Rows.Count.ToString());
        /*    int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            label1.Text = sum.ToString();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
