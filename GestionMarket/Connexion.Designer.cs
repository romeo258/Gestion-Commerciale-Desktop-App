namespace GestionMarket
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.pseudoCnx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mdpCnx = new System.Windows.Forms.TextBox();
            this.connecter = new System.Windows.Forms.Button();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 339);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.White;
            this.AppName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AppName.Location = new System.Drawing.Point(295, 9);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(149, 33);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "CAVE RELAX";
            // 
            // pseudoCnx
            // 
            this.pseudoCnx.Location = new System.Drawing.Point(242, 136);
            this.pseudoCnx.Name = "pseudoCnx";
            this.pseudoCnx.Size = new System.Drawing.Size(248, 27);
            this.pseudoCnx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(238, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo Du Vendeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(238, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot De Passe";
            // 
            // mdpCnx
            // 
            this.mdpCnx.Location = new System.Drawing.Point(242, 212);
            this.mdpCnx.Name = "mdpCnx";
            this.mdpCnx.Size = new System.Drawing.Size(248, 27);
            this.mdpCnx.TabIndex = 3;
            this.mdpCnx.TextChanged += new System.EventHandler(this.mdpCnx_TextChanged);
            // 
            // connecter
            // 
            this.connecter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connecter.FlatAppearance.BorderSize = 0;
            this.connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connecter.Location = new System.Drawing.Point(301, 266);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(143, 42);
            this.connecter.TabIndex = 5;
            this.connecter.Text = "Se Connecter";
            this.connecter.UseVisualStyleBackColor = false;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // reduire
            // 
            this.reduire.BackColor = System.Drawing.Color.Transparent;
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.ForeColor = System.Drawing.Color.Transparent;
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(505, 0);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(29, 30);
            this.reduire.TabIndex = 15;
            this.reduire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reduire.UseVisualStyleBackColor = false;
            this.reduire.Click += new System.EventHandler(this.reduire_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.Transparent;
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.Transparent;
            this.fermer.Image = ((System.Drawing.Image)(resources.GetObject("fermer.Image")));
            this.fermer.Location = new System.Drawing.Point(540, 0);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(35, 29);
            this.fermer.TabIndex = 14;
            this.fermer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Connexion
            // 
            this.AcceptButton = this.connecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 339);
            this.Controls.Add(this.reduire);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mdpCnx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pseudoCnx);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.TextBox pseudoCnx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mdpCnx;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
    }
}

