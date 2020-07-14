using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User")
            {
                User f = new User();
                f.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Clerk")
            {
                Clerk f = new Clerk();
                f.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Judge")
            {
                Judge f = new Judge();
                f.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Director")
            {
                Director f = new Director();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }
    }
}
