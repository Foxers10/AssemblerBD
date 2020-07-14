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
    public partial class Chair : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public Chair()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Судья ORDER BY Код_судьи";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
            }

            reader.Close();
        }

        private void SelectButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", "
                + reader[5].ToString() + ", " + reader[6].ToString() + ", " + reader[7].ToString());
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
        }

        private void SelectButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты ORDER BY Номер_акта";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", "
                + reader[5].ToString() + ", " + reader[6].ToString() + ", " + reader[7].ToString());
            }

            reader.Close();
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Судебные_акты SET Код_судьи = '" + JudBox.Text + "' WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void Chair_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Судья (ФИО_судьи, Зарплата, Опыт_работы) VALUES ('" + NewBox1.Text + "' , '" + MoneyBox1.Text + "' , '" + TimeBox2.Text + "')";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Недостаточно введенных данных!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судья ORDER BY Код_судьи";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
            }

            reader.Close();
        }

        private void Chair_Load(object sender, EventArgs e)
        {

        }
    }
}
