
namespace bibliothèque
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gbId = new System.Windows.Forms.Button();
            this.guId = new System.Windows.Forms.Button();
            this.geId = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbId
            // 
            this.gbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbId.Location = new System.Drawing.Point(48, 197);
            this.gbId.Name = "gbId";
            this.gbId.Size = new System.Drawing.Size(153, 57);
            this.gbId.TabIndex = 0;
            this.gbId.Text = "Gestion de la bibliothèque";
            this.gbId.UseVisualStyleBackColor = true;
            this.gbId.Click += new System.EventHandler(this.gbId_Click);
            // 
            // guId
            // 
            this.guId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.guId.Location = new System.Drawing.Point(334, 197);
            this.guId.Name = "guId";
            this.guId.Size = new System.Drawing.Size(125, 57);
            this.guId.TabIndex = 1;
            this.guId.Text = "Gestion des utilisateurs";
            this.guId.UseVisualStyleBackColor = true;
            this.guId.Click += new System.EventHandler(this.guId_Click);
            // 
            // geId
            // 
            this.geId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.geId.Location = new System.Drawing.Point(593, 197);
            this.geId.Name = "geId";
            this.geId.Size = new System.Drawing.Size(134, 57);
            this.geId.TabIndex = 2;
            this.geId.Text = "Gestion des emprunts";
            this.geId.UseVisualStyleBackColor = true;
            this.geId.Click += new System.EventHandler(this.geId_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.LemonChiffon;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.Red;
            this.quit.Location = new System.Drawing.Point(690, 401);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 27);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.geId);
            this.Controls.Add(this.guId);
            this.Controls.Add(this.gbId);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gbId;
        private System.Windows.Forms.Button guId;
        private System.Windows.Forms.Button geId;
        private System.Windows.Forms.Button quit;
    }
}