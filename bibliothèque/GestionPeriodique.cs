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
    public partial class GestionPeriodique : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id = 0;
        public GestionPeriodique()
        {
            InitializeComponent();
        }

        private void id_Ajout_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            string nom = textBox1.Text;
            string num = textBox2.Text;
            string periodicite = textBox3.Text;
            string no = textBox4.Text;
            string dateE = dateTimePicker1.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""&& textBox4.Text != "")
            {
                Periodique p = new Periodique(nom, periodicite, num, dateE, no);
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into periodique(nom, numero, periodicite,date,Numero_Ouvrage) values(@nom, @numero, @periodicite,@dateE,@NumO)";
                cmd.Parameters.AddWithValue("@nom", p.titre);
                cmd.Parameters.AddWithValue("@numero", p.Numero);
                cmd.Parameters.AddWithValue("@periodicite", p.Periodicite);
                cmd.Parameters.AddWithValue("@dateE", p.Cote);
                cmd.Parameters.AddWithValue("@NumO", p.DateEmprunt );
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

       

        private void Id_mdf_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update periodique set nom=@nom,numero=@numero,periodicite=@periodicite where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                cmd.Parameters.AddWithValue("@numero", textBox2.Text);
                cmd.Parameters.AddWithValue("@periodicite", textBox3.Text);
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

        private void id_spr_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "delete from periodique where id =@id";
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

            String request = "select * from periodique";

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
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Id_mdf.Enabled = true;
            id_spr.Enabled = true;
        }
    }
}
