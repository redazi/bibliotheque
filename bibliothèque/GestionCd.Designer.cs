
namespace bibliothèque
{
    partial class GestionCd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCd));
            this.quit = new System.Windows.Forms.Button();
            this.id_spr = new System.Windows.Forms.Button();
            this.Id_mdf = new System.Windows.Forms.Button();
            this.id_Ajout = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id_titre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idAut = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afficher = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.quit.Location = new System.Drawing.Point(690, 387);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(65, 33);
            this.quit.TabIndex = 21;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
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
            this.id_spr.Click += new System.EventHandler(this.id_spr_Click);
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
            this.Id_mdf.Click += new System.EventHandler(this.Id_mdf_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // id_titre
            // 
            this.id_titre.AutoSize = true;
            this.id_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_titre.Location = new System.Drawing.Point(259, 79);
            this.id_titre.Name = "id_titre";
            this.id_titre.Size = new System.Drawing.Size(37, 18);
            this.id_titre.TabIndex = 14;
            this.id_titre.Text = "Titre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // idAut
            // 
            this.idAut.AutoSize = true;
            this.idAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAut.Location = new System.Drawing.Point(37, 79);
            this.idAut.Name = "idAut";
            this.idAut.Size = new System.Drawing.Size(50, 18);
            this.idAut.TabIndex = 12;
            this.idAut.Text = "Auteur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 162);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // afficher
            // 
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.afficher.Location = new System.Drawing.Point(690, 161);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(75, 37);
            this.afficher.TabIndex = 23;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(400, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 27;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero ouvrage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // GestionCd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.id_spr);
            this.Controls.Add(this.Id_mdf);
            this.Controls.Add(this.id_Ajout);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.id_titre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idAut);
            this.Name = "GestionCd";
            this.Text = "GestionCd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button id_spr;
        private System.Windows.Forms.Button Id_mdf;
        private System.Windows.Forms.Button id_Ajout;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label id_titre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idAut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}