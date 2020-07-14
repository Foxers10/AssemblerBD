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
    public partial class Judge : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public Judge()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void Judge_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
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
            string query = "UPDATE Судебные_акты SET Выводы_суда = '" + SolBox.Text + "', Дата_решения_суда = '" +  DateTime.Today + "' WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void Judge_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
