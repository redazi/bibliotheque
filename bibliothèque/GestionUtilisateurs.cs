using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliothèque
{
    public partial class GestionUtilisateurs : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id = 0;
        public GestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            string nom = textBox1.Text;
            string password = textBox2.Text;
            User u = new User(nom, password);
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into users(login, password) values(@login, @password)";
                cmd.Parameters.AddWithValue("@login", u.login);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.ExecuteNonQuery();

                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from users";

            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridView1.DataSource = data;

            connection.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            modifier.Enabled = true;
            supprimer.Enabled = true;
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" )
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update users set login=@login,password=@password where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@login", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "delete from users where id =@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
