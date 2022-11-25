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
    public partial class signIn : Form
    {
        String parametres = "SERVER=127.0.0.1; DATABASE=bibliotheque; UID=root; PASSWORD=";

        public signIn()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            string nom = idUserName.Text;
            string pswd = pwd.Text;
            MySqlConnection connection = new MySqlConnection(parametres);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM users where login='" + nom + "' AND password='" + pswd + "'";
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            connection.Close();
           

        }

        private void visibilité_Click(object sender, EventArgs e)
        {
            if (pwd.UseSystemPasswordChar == true)
            {
                pwd.UseSystemPasswordChar = false;
                visibilité.Text = "Hide";
                visibilité.BackColor = Color.Gray;
            }
            else
            {
                pwd.UseSystemPasswordChar = true;
                visibilité.Text = "Show";
                visibilité.BackColor = Color.PeachPuff;
            }
        }
    }
}
