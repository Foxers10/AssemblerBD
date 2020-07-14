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
    public partial class Document : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Tribunal.mdb;";
        private OleDbConnection myConnection;
        public Document()
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Документ WHERE Код_документа = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString());
            }

            reader.Close();
        }

        private void SelectButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Документ ORDER BY Код_документа";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString());
            }

            reader.Close();
        }

        private void InsertButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Документ (Название_документа, Содержание_документа, Комплект) VALUES ('" + LocationBox2.Text + "' , '" + ContentBox1.Text + "' , '" + textBox1.Text + "')";

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
            string query = "UPDATE Документ SET Название_документа = '" + LocationBox2.Text + "', Содержание_документа = '" + ContentBox1.Text + "', Комплект = '" + textBox1.Text  + "' WHERE Код_документа = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            string query = "Delete FROM Документ WHERE Код_документа = " + IDBox1.Text;

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization f = new Autorization();
            f.Show();
            this.Hide();
        }

        private void Document_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LocationBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Document_Load(object sender, EventArgs e)
        {

        }
    }
}
