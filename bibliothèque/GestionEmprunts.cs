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
    public partial class GestionEmprunts : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";
        int id = 0;
        public GestionEmprunts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
 
            dataGridView2.Visible = true;
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from periodique";

            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridView2.DataSource = data;

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from cd";

            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridView3.DataSource = data;

            connection.Close();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            Emprunt emp = new Emprunt(textBox1.Text,  textBox2.Text, dateTimePicker1.Text, textBox4.Text, textBox3.Text, dateTimePicker2.Text);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&textBox4.Text!="")
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into emprunt(nom, cin,NumeroOuvrage,Type,Delai,DateEmprunt) values(@nom, @cin,@NumeroOuvrage,@Type,@Delai,@DateEmprunt)";
                cmd.Parameters.AddWithValue("@nom",emp.nom);
                cmd.Parameters.AddWithValue("@cin", emp.cin);
                cmd.Parameters.AddWithValue("@NumeroOuvrage",emp.NumO);
                cmd.Parameters.AddWithValue("@Type",emp.TypeOuvr);
                cmd.Parameters.AddWithValue("@Delai", emp.delai);
                cmd.Parameters.AddWithValue("@DateEmprunt", emp.dateE);
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

        private void spr_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "delete from emprunt where id =@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text!="" && textBox4.Text!="")
            {
                MySqlConnection connection = new MySqlConnection(parametres);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "update emprunt set nom=@nom,cin=@cin,NumeroOuvrage=@NumeroOuvrage,type=@type,delai=@delai,DateEmprunt=@DateEmprunt where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                cmd.Parameters.AddWithValue("@cin", textBox2.Text);
                cmd.Parameters.AddWithValue("@NumeroOuvrage", textBox3.Text);
                cmd.Parameters.AddWithValue("@type", textBox4.Text);
                cmd.Parameters.AddWithValue("@delai", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@DateEmprunt", dateTimePicker2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();

            String request = "select * from emprunt";

            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridView4.DataSource = data;

            connection.Close();
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(dataGridView4.SelectedRows[0].Cells[0].Value.ToString());
            textBox1.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            modifier.Enabled = true;
            spr.Enabled = true;
        }

        private void GestionEmprunts_Load(object sender, EventArgs e)
        {

        }
    }
}
