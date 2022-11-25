
namespace bibliothèque
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.livre = new System.Windows.Forms.Button();
            this.periodique = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // livre
            // 
            this.livre.BackColor = System.Drawing.Color.LightGray;
            this.livre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livre.Location = new System.Drawing.Point(77, 158);
            this.livre.Name = "livre";
            this.livre.Size = new System.Drawing.Size(126, 39);
            this.livre.TabIndex = 0;
            this.livre.Text = "Gérer les livres";
            this.livre.UseVisualStyleBackColor = false;
            this.livre.Click += new System.EventHandler(this.livre_Click);
            // 
            // periodique
            // 
            this.periodique.BackColor = System.Drawing.Color.LightGray;
            this.periodique.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodique.Location = new System.Drawing.Point(316, 265);
            this.periodique.Name = "periodique";
            this.periodique.Size = new System.Drawing.Size(169, 36);
            this.periodique.TabIndex = 1;
            this.periodique.Text = "Gérer les périodiques";
            this.periodique.UseVisualStyleBackColor = false;
            this.periodique.Click += new System.EventHandler(this.periodique_Click);
            // 
            // cd
            // 
            this.cd.BackColor = System.Drawing.Color.LightGray;
            this.cd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd.Location = new System.Drawing.Point(598, 158);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(110, 39);
            this.cd.TabIndex = 2;
            this.cd.Text = "Gérer les CD";
            this.cd.UseVisualStyleBackColor = false;
            this.cd.Click += new System.EventHandler(this.cd_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cd);
            this.Controls.Add(this.periodique);
            this.Controls.Add(this.livre);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button livre;
        private System.Windows.Forms.Button periodique;
        private System.Windows.Forms.Button cd;
    }
}