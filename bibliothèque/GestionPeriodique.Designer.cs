
namespace bibliothèque
{
    partial class GestionPeriodique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPeriodique));
            this.quit = new System.Windows.Forms.Button();
            this.id_spr = new System.Windows.Forms.Button();
            this.Id_mdf = new System.Windows.Forms.Button();
            this.id_Ajout = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id_ed = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id_titre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idNom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afficher = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.Red;
            this.quit.Location = new System.Drawing.Point(700, 336);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(65, 33);
            this.quit.TabIndex = 21;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            // 
            // id_spr
            // 
            this.id_spr.Enabled = false;
            this.id_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_spr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_spr.Location = new System.Drawing.Point(690, 114);
            this.id_spr.Name = "id_spr";
            this.id_spr.Size = new System.Drawing.Size(92, 41);
            this.id_spr.TabIndex = 20;
            this.id_spr.Text = "Supprimer";
            this.id_spr.UseVisualStyleBackColor = true;
            this.id_spr.Click += new System.EventHandler(this.id_spr_Click_1);
            // 
            // Id_mdf
            // 
            this.Id_mdf.Enabled = false;
            this.Id_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_mdf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Id_mdf.Location = new System.Drawing.Point(690, 71);
            this.Id_mdf.Name = "Id_mdf";
            this.Id_mdf.Size = new System.Drawing.Size(75, 37);
            this.Id_mdf.TabIndex = 19;
            this.Id_mdf.Text = "Modifier";
            this.Id_mdf.UseVisualStyleBackColor = true;
            this.Id_mdf.Click += new System.EventHandler(this.Id_mdf_Click_1);
            // 
            // id_Ajout
            // 
            this.id_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Ajout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_Ajout.Location = new System.Drawing.Point(690, 31);
            this.id_Ajout.Name = "id_Ajout";
            this.id_Ajout.Size = new System.Drawing.Size(75, 34);
            this.id_Ajout.TabIndex = 18;
            this.id_Ajout.Text = "Ajouter";
            this.id_Ajout.UseVisualStyleBackColor = true;
            this.id_Ajout.Click += new System.EventHandler(this.id_Ajout_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(539, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // id_ed
            // 
            this.id_ed.AutoSize = true;
            this.id_ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ed.Location = new System.Drawing.Point(465, 59);
            this.id_ed.Name = "id_ed";
            this.id_ed.Size = new System.Drawing.Size(75, 18);
            this.id_ed.TabIndex = 16;
            this.id_ed.Text = "périodicité";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // id_titre
            // 
            this.id_titre.AutoSize = true;
            this.id_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_titre.Location = new System.Drawing.Point(240, 57);
            this.id_titre.Name = "id_titre";
            this.id_titre.Size = new System.Drawing.Size(62, 18);
            this.id_titre.TabIndex = 14;
            this.id_titre.Text = "Numéro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // idNom
            // 
            this.idNom.AutoSize = true;
            this.idNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNom.Location = new System.Drawing.Point(18, 57);
            this.idNom.Name = "idNom";
            this.idNom.Size = new System.Drawing.Size(41, 18);
            this.idNom.TabIndex = 12;
            this.idNom.Text = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 187);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // afficher
            // 
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.afficher.Location = new System.Drawing.Point(690, 173);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(75, 37);
            this.afficher.TabIndex = 23;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(368, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numéro Ouvrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // GestionPeriodique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.idNom);
            this.Name = "GestionPeriodique";
            this.Text = "GestionPeriodique";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button id_spr;
        private System.Windows.Forms.Button Id_mdf;
        private System.Windows.Forms.Button id_Ajout;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label id_ed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label id_titre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}