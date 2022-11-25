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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            signIn signIn = new signIn();
            this.Hide();
            signIn.Show();
        }

        private void gbId_Click(object sender, EventArgs e)
        {
            Options o = new Options();
            this.Hide();
            o.Show();
        }

        private void geId_Click(object sender, EventArgs e)
        {
            GestionEmprunts ge = new GestionEmprunts();
            ge.Show();
            this.Hide();
        }

        private void guId_Click(object sender, EventArgs e)
        {
            GestionUtilisateurs gu = new GestionUtilisateurs();
            gu.Show();
            this.Hide();
        }
    }
}
