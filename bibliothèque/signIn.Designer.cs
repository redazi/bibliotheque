
namespace bibliothèque
{
    partial class signIn
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idUserName = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.visibilité = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(38, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(43, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // idUserName
            // 
            this.idUserName.Location = new System.Drawing.Point(298, 189);
            this.idUserName.Name = "idUserName";
            this.idUserName.Size = new System.Drawing.Size(140, 20);
            this.idUserName.TabIndex = 2;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(298, 234);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(140, 20);
            this.pwd.TabIndex = 3;
            this.pwd.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Coral;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(216, 303);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(101, 37);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.DarkRed;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Error.Location = new System.Drawing.Point(67, 83);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(57, 24);
            this.Error.TabIndex = 5;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // visibilité
            // 
            this.visibilité.BackColor = System.Drawing.Color.PeachPuff;
            this.visibilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilité.Location = new System.Drawing.Point(453, 234);
            this.visibilité.Name = "visibilité";
            this.visibilité.Size = new System.Drawing.Size(54, 23);
            this.visibilité.TabIndex = 6;
            this.visibilité.Text = "Show";
            this.visibilité.UseVisualStyleBackColor = false;
            this.visibilité.Click += new System.EventHandler(this.visibilité_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.visibilité);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.idUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signIn";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idUserName;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button visibilité;
    }
}

