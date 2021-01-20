using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Resturant
{
    public partial class Form4 : Form
    {
        DataClasses1DataContext con = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Resturant\Resturant\nnn.mdf;Integrated Security=True;Connect Timeout=30");

        public Form4()
        {
            InitializeComponent();
            fill();
        }
        private void fill()
        {
            this.dataGridView3.DataSource = con.select_jobs();
            var a = con.select_jobs().ToArray();
            MessageBox.Show(a[0].salary.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
