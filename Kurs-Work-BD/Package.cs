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
    public partial class Package : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public Package()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void Package_Load(object sender, EventArgs e)
        {

        }


        private void Package_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
        }

        private void SelectButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Расположение FROM Комплект_документов WHERE Код_комплекта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            listBox1.Items.Add(command.ExecuteScalar().ToString());
        }

        private void SelectButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Комплект_документов ORDER BY Код_комплекта";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString());
            }

            reader.Close();
        }

        private void InsertButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Комплект_документов (Расположение) VALUES ('" + LocationBox2.Text + "')";

                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Недостаточно введенных данных!");
            }
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Комплект_документов SET Расположение = '" + LocationBox2.Text + "' WHERE Код_комплекта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            string query = "Delete FROM Комплект_документов WHERE Код_комплекта = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
