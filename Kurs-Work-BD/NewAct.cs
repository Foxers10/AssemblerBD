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
    public partial class NewAct : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public NewAct()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Комплект_документов ORDER BY Код_комплекта";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
            }

            reader.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты ORDER BY Номер_акта";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[4].ToString() + ", " + reader[7].ToString());
            }

            reader.Close();
        }

        private void NewAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void NewAct_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelectButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Судебные_акты WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[4].ToString() + ", " + reader[7].ToString());
            }

            reader.Close();
        }

        private void InsertButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Судебные_акты (Истец, Ответчик, Предмет_спора, Комплект_документов) VALUES ('" + IstecBox2.Text + "' , '" + OtvetBox1.Text + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "')";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Недостаточно введенных данных!");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Судебные_акты SET Истец = '" + IstecBox2.Text + "', Ответчик = '" + OtvetBox1.Text + "', Предмет_спора = '" + textBox1.Text + "', Комплект_документов = '" + textBox2.Text + "' WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            string query = "Delete FROM Судебные_акты WHERE Номер_акта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
        }
    }
}
