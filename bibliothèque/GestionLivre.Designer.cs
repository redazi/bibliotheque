
namespace bibliothèque
{
    partial class GestionLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLivre));
            this.idAut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id_titre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id_ed = new System.Windows.Forms.Label();
            this.id_Ajout = new System.Windows.Forms.Button();
            this.Id_mdf = new System.Windows.Forms.Button();
            this.id_spr = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afficher = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idAut
            // 
            this.idAut.AutoSize = true;
            this.idAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAut.Location = new System.Drawing.Point(668, 15);
            this.idAut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idAut.Name = "idAut";
            this.idAut.Size = new System.Drawing.Size(66, 24);
            this.idAut.TabIndex = 1;
            this.idAut.Text = "Auteur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(844, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(844, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // id_titre
            // 
            this.id_titre.AutoSize = true;
            this.id_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_titre.Location = new System.Drawing.Point(668, 62);
            this.id_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_titre.Name = "id_titre";
            this.id_titre.Size = new System.Drawing.Size(47, 24);
            this.id_titre.TabIndex = 3;
            this.id_titre.Text = "Titre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(844, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            // 
            // id_ed
            // 
            this.id_ed.AutoSize = true;
            this.id_ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ed.Location = new System.Drawing.Point(668, 112);
            this.id_ed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_ed.Name = "id_ed";
            this.id_ed.Size = new System.Drawing.Size(70, 24);
            this.id_ed.TabIndex = 5;
            this.id_ed.Text = "Editeur";
            // 
            // id_Ajout
            // 
            this.id_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Ajout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_Ajout.Location = new System.Drawing.Point(673, 265);
            this.id_Ajout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_Ajout.Name = "id_Ajout";
            this.id_Ajout.Size = new System.Drawing.Size(100, 42);
            this.id_Ajout.TabIndex = 7;
            this.id_Ajout.Text = "Ajouter";
            this.id_Ajout.UseVisualStyleBackColor = true;
            this.id_Ajout.Click += new System.EventHandler(this.id_Ajout_Click);
            // 
            // Id_mdf
            // 
            this.Id_mdf.Enabled = false;
            this.Id_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_mdf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Id_mdf.Location = new System.Drawing.Point(709, 369);
            this.Id_mdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Id_mdf.Name = "Id_mdf";
            this.Id_mdf.Size = new System.Drawing.Size(100, 46);
            this.Id_mdf.TabIndex = 8;
            this.Id_mdf.Text = "Modifier";
            this.Id_mdf.UseVisualStyleBackColor = true;
            this.Id_mdf.Click += new System.EventHandler(this.Id_mdf_Click);
            // 
            // id_spr
            // 
            this.id_spr.Enabled = false;
            this.id_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_spr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_spr.Location = new System.Drawing.Point(855, 369);
            this.id_spr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_spr.Name = "id_spr";
            this.id_spr.Size = new System.Drawing.Size(123, 46);
            this.id_spr.TabIndex = 9;
            this.id_spr.Text = "Supprimer";
            this.id_spr.UseVisualStyleBackColor = true;
            this.id_spr.Click += new System.EventHandler(this.id_spr_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.Red;
            this.quit.Location = new System.Drawing.Point(921, 498);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(87, 41);
            this.quit.TabIndex = 10;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(572, 249);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // afficher
            // 
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.afficher.Location = new System.Drawing.Point(905, 265);
            this.afficher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(100, 42);
            this.afficher.TabIndex = 12;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(844, 166);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero  Ouvrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(844, 215);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // GestionLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.id_spr);
            this.Controls.Add(this.Id_mdf);
            this.Controls.Add(this.id_Ajout);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.id_ed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.id_titre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idAut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionLivre";
            this.Text = "Gestion des Livre";
            this.Load += new System.EventHandler(this.GestionLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idAut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label id_titre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label id_ed;
        private System.Windows.Forms.Button id_Ajout;
        private System.Windows.Forms.Button Id_mdf;
        private System.Windows.Forms.Button id_spr;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}