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
    public partial class signin : Form
    {
        DataClasses1DataContext con = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Resturant\Resturant\nnn.mdf;Integrated Security=True;Connect Timeout=30");
        public signin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_CATEGOREA s = new FORM_CATEGOREA();
            s.ShowDialog();        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            user_textbox.Text = "";
            password_textbox.Text = "";
        }
    }
}
