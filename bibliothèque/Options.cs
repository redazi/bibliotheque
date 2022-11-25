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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void livre_Click(object sender, EventArgs e)
        {
            GestionLivre gl = new GestionLivre();
            gl.Show();
            this.Hide();
        }

        private void periodique_Click(object sender, EventArgs e)
        {
            GestionPeriodique gp = new GestionPeriodique();
            this.Hide();
            gp.Show();
        }

        private void cd_Click(object sender, EventArgs e)
        {
            GestionCd gc = new GestionCd();
            this.Hide();
            gc.Show();
        }
    }
}
