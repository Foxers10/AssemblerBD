using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Work_BD
{
    public partial class User : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public User()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты ORDER BY Номер_акта";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() 
                + ", " + reader[5].ToString() + ", " + reader[6].ToString() + ", " + reader[7].ToString());
            }

            reader.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты WHERE ( Истец = '" + textBox1.Text + "' OR Ответчик = '" + textBox1.Text + "')";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString()
                + " " + reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString());
            }

            reader.Close();
        }

        private void User_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
        }
    }
}
