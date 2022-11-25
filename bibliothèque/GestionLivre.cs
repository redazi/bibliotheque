using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliothèque
{
    public partial class GestionLivre : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id = 0;
        public GestionLivre()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void id_Ajout_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            string auteur = textBox1.Text;
            string titre = textBox2.Text;
            string  editeur = textBox3.Text;
            string no = textBox4.Text;
            string date = dateTimePicker1.Text;
            Livre l = new Livre(auteur, titre, date, no, editeur);
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text != ""&&textBox4.Text!="") {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into livre(auteur, titre, editeur,dateE,NumO) values(@auteur, @titre, @editeur,@dateE,@NumO)";
            cmd.Parameters.AddWithValue("@auteur", l.auteur);
            cmd.Parameters.AddWithValue("@titre", l.titre);
            cmd.Parameters.AddWithValue("@editeur",l.editeur);
            cmd.Parameters.AddWithValue("@dateE", l.DateEmprunt);
            cmd.Parameters.AddWithValue("@NumO", l.Cote);

                cmd.ExecuteNonQuery();

            connection.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Home h  = new Home();
            this.Hide();
            h.Show();
        }

        

     
        

        private void id_spr_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "delete from livre where id =@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }


        }

        private void afficher_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from livre";

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
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Id_mdf.Enabled = true;
            id_spr.Enabled = true;
        }

        private void Id_mdf_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update livre set auteur=@auteur,titre=@titre,editeur=@editeur where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@auteur", textBox1.Text);
                cmd.Parameters.AddWithValue("@titre", textBox2.Text);
                cmd.Parameters.AddWithValue("@editeur", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void GestionLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
