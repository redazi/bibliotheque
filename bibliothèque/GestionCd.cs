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
    public partial class GestionCd : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id = 0;
        public GestionCd()
        {
            InitializeComponent();
        }

        private void id_Ajout_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            string auteur = textBox1.Text;
            string titre = textBox2.Text;
            string date = dateTimePicker1.Text;
            string no = textBox3.Text;
            Cd cd = new Cd(titre, auteur, date, no);
            if (textBox1.Text != "" && textBox2.Text != ""&&textBox3.Text!="" )
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into cd(auteur, titre,dateE,NumO) values(@auteur, @titre,@dateE,@NumO)";
                cmd.Parameters.AddWithValue("@auteur", cd.auteur);
                cmd.Parameters.AddWithValue("@titre", cd.titre);
                cmd.Parameters.AddWithValue("@dateE", cd.DateEmprunt);
                cmd.Parameters.AddWithValue("@NumO", cd.Cote);
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

        private void Id_mdf_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update cd set auteur=@auteur,titre=@titre where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@auteur", textBox1.Text);
                cmd.Parameters.AddWithValue("@titre", textBox2.Text);
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

       

        private void id_spr_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "delete from cd where id =@id";
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

        private void quit_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from cd";

            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridView1.DataSource = data;

            connection.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Id_mdf.Enabled = true;
            id_spr.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
