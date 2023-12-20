namespace GestionMarket
{
    partial class Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.TextLabel2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prixA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stockA = new System.Windows.Forms.TextBox();
            this.categorieA = new System.Windows.Forms.ComboBox();
            this.textlabel = new System.Windows.Forms.Label();
            this.enregistrerArt = new System.Windows.Forms.Button();
            this.modifierArt = new System.Windows.Forms.Button();
            this.supprimerArt = new System.Windows.Forms.Button();
            this.dgvListArt = new Guna.UI.WinForms.GunaDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.listeArtParCat = new System.Windows.Forms.ComboBox();
            this.actualiserArt = new System.Windows.Forms.Button();
            this.dateExpiration = new Guna.UI.WinForms.GunaDateTimePicker();
            this.codeArticle = new System.Windows.Forms.TextBox();
            this.nomA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.TextLabel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 646);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(48, 553);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 64;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // TextLabel2
            // 
            this.TextLabel2.AutoSize = true;
            this.TextLabel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TextLabel2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel2.ForeColor = System.Drawing.Color.Black;
            this.TextLabel2.Location = new System.Drawing.Point(17, 606);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.Size = new System.Drawing.Size(126, 26);
            this.TextLabel2.TabIndex = 63;
            this.TextLabel2.Text = "Déconnexion";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 419);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 281);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(55, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Facturation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-10, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(59, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Vendeurs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(59, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Categories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(59, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Articles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.reduire);
            this.panel2.Controls.Add(this.fermer);
            this.panel2.Controls.Add(this.AppName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 47);
            this.panel2.TabIndex = 2;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(385, 9);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(241, 33);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "Gestion Des Articles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(195, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom de l\'article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(434, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix de l\'article en CFA";
            // 
            // prixA
            // 
            this.prixA.Location = new System.Drawing.Point(438, 126);
            this.prixA.Name = "prixA";
            this.prixA.Size = new System.Drawing.Size(163, 27);
            this.prixA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(657, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Catégorie ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(839, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock";
            // 
            // stockA
            // 
            this.stockA.Location = new System.Drawing.Point(843, 126);
            this.stockA.Name = "stockA";
            this.stockA.Size = new System.Drawing.Size(79, 27);
            this.stockA.TabIndex = 9;
            // 
            // categorieA
            // 
            this.categorieA.FormattingEnabled = true;
            this.categorieA.Location = new System.Drawing.Point(661, 126);
            this.categorieA.Name = "categorieA";
            this.categorieA.Size = new System.Drawing.Size(121, 27);
            this.categorieA.TabIndex = 11;
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textlabel.Location = new System.Drawing.Point(968, 101);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(127, 19);
            this.textlabel.TabIndex = 12;
            this.textlabel.Text = "Date d\'Expiration";
            // 
            // enregistrerArt
            // 
            this.enregistrerArt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.enregistrerArt.FlatAppearance.BorderSize = 0;
            this.enregistrerArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrerArt.ForeColor = System.Drawing.Color.Black;
            this.enregistrerArt.Location = new System.Drawing.Point(385, 184);
            this.enregistrerArt.Name = "enregistrerArt";
            this.enregistrerArt.Size = new System.Drawing.Size(152, 30);
            this.enregistrerArt.TabIndex = 14;
            this.enregistrerArt.Text = "Enregistrer";
            this.enregistrerArt.UseVisualStyleBackColor = false;
            this.enregistrerArt.Click += new System.EventHandler(this.enregistrerArt_Click);
            // 
            // modifierArt
            // 
            this.modifierArt.BackColor = System.Drawing.Color.CadetBlue;
            this.modifierArt.FlatAppearance.BorderSize = 0;
            this.modifierArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierArt.ForeColor = System.Drawing.Color.Black;
            this.modifierArt.Location = new System.Drawing.Point(605, 184);
            this.modifierArt.Name = "modifierArt";
            this.modifierArt.Size = new System.Drawing.Size(149, 30);
            this.modifierArt.TabIndex = 15;
            this.modifierArt.Text = "Modifier";
            this.modifierArt.UseVisualStyleBackColor = false;
            this.modifierArt.Click += new System.EventHandler(this.modifierArt_Click);
            // 
            // supprimerArt
            // 
            this.supprimerArt.BackColor = System.Drawing.Color.RosyBrown;
            this.supprimerArt.FlatAppearance.BorderSize = 0;
            this.supprimerArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerArt.ForeColor = System.Drawing.Color.Black;
            this.supprimerArt.Location = new System.Drawing.Point(823, 184);
            this.supprimerArt.Name = "supprimerArt";
            this.supprimerArt.Size = new System.Drawing.Size(149, 30);
            this.supprimerArt.TabIndex = 16;
            this.supprimerArt.Text = "Supprimer";
            this.supprimerArt.UseVisualStyleBackColor = false;
            this.supprimerArt.Click += new System.EventHandler(this.supprimerArt_Click);
            // 
            // dgvListArt
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvListArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListArt.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListArt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListArt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListArt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListArt.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListArt.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListArt.EnableHeadersVisualStyles = false;
            this.dgvListArt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListArt.Location = new System.Drawing.Point(199, 317);
            this.dgvListArt.Name = "dgvListArt";
            this.dgvListArt.ReadOnly = true;
            this.dgvListArt.RowHeadersVisible = false;
            this.dgvListArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListArt.Size = new System.Drawing.Size(958, 317);
            this.dgvListArt.TabIndex = 17;
            this.dgvListArt.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvListArt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListArt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListArt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListArt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListArt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListArt.ThemeStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListArt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListArt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListArt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListArt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvListArt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListArt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListArt.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListArt.ThemeStyle.ReadOnly = true;
            this.dgvListArt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListArt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListArt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvListArt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.dgvListArt.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListArt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListArt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListArt_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(601, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Liste Des Articles";
            // 
            // listeArtParCat
            // 
            this.listeArtParCat.FormattingEnabled = true;
            this.listeArtParCat.Location = new System.Drawing.Point(23, 29);
            this.listeArtParCat.Name = "listeArtParCat";
            this.listeArtParCat.Size = new System.Drawing.Size(121, 27);
            this.listeArtParCat.TabIndex = 19;
            this.listeArtParCat.SelectedIndexChanged += new System.EventHandler(this.listeArtParCat_SelectedIndexChanged);
            // 
            // actualiserArt
            // 
            this.actualiserArt.BackColor = System.Drawing.SystemColors.Highlight;
            this.actualiserArt.FlatAppearance.BorderSize = 0;
            this.actualiserArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualiserArt.ForeColor = System.Drawing.Color.Black;
            this.actualiserArt.Location = new System.Drawing.Point(150, 26);
            this.actualiserArt.Name = "actualiserArt";
            this.actualiserArt.Size = new System.Drawing.Size(143, 30);
            this.actualiserArt.TabIndex = 20;
            this.actualiserArt.Text = "actualiser";
            this.actualiserArt.UseVisualStyleBackColor = false;
            this.actualiserArt.Click += new System.EventHandler(this.actualiserArt_Click);
            // 
            // dateExpiration
            // 
            this.dateExpiration.BackColor = System.Drawing.Color.Blue;
            this.dateExpiration.BaseColor = System.Drawing.SystemColors.Highlight;
            this.dateExpiration.BorderColor = System.Drawing.Color.Silver;
            this.dateExpiration.CustomFormat = null;
            this.dateExpiration.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateExpiration.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateExpiration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpiration.ForeColor = System.Drawing.Color.Black;
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateExpiration.Location = new System.Drawing.Point(972, 123);
            this.dateExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateExpiration.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateExpiration.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateExpiration.OnPressedColor = System.Drawing.Color.Black;
            this.dateExpiration.Size = new System.Drawing.Size(185, 30);
            this.dateExpiration.TabIndex = 21;
            this.dateExpiration.Text = "2023-03-04";
            this.dateExpiration.Value = new System.DateTime(2023, 3, 4, 4, 36, 26, 589);
            this.dateExpiration.ValueChanged += new System.EventHandler(this.dateExpiration_ValueChanged);
            // 
            // codeArticle
            // 
            this.codeArticle.Location = new System.Drawing.Point(199, 126);
            this.codeArticle.Name = "codeArticle";
            this.codeArticle.Size = new System.Drawing.Size(10, 27);
            this.codeArticle.TabIndex = 22;
            // 
            // nomA
            // 
            this.nomA.Location = new System.Drawing.Point(199, 126);
            this.nomA.Name = "nomA";
            this.nomA.Size = new System.Drawing.Size(187, 27);
            this.nomA.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listeArtParCat);
            this.groupBox1.Controls.Add(this.actualiserArt);
            this.groupBox1.Location = new System.Drawing.Point(843, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 70);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trier Par Categorie";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.searchA);
            this.groupBox2.Location = new System.Drawing.Point(199, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 70);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trouver Un Article";
            // 
            // searchA
            // 
            this.searchA.Location = new System.Drawing.Point(6, 29);
            this.searchA.Name = "searchA";
            this.searchA.Size = new System.Drawing.Size(264, 27);
            this.searchA.TabIndex = 26;
            this.searchA.TextChanged += new System.EventHandler(this.searchA_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(-4, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 23);
            this.label12.TabIndex = 72;
            this.label12.Text = "Gestion Market";
            // 
            // reduire
            // 
            this.reduire.BackColor = System.Drawing.SystemColors.Highlight;
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(973, 12);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(24, 22);
            this.reduire.TabIndex = 13;
            this.reduire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reduire.UseVisualStyleBackColor = false;
            this.reduire.Click += new System.EventHandler(this.reduire_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.Highlight;
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fermer.Image = ((System.Drawing.Image)(resources.GetObject("fermer.Image")));
            this.fermer.Location = new System.Drawing.Point(1003, 3);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(35, 38);
            this.fermer.TabIndex = 12;
            this.fermer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.supprimerArt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nomA);
            this.Controls.Add(this.codeArticle);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListArt);
            this.Controls.Add(this.modifierArt);
            this.Controls.Add(this.enregistrerArt);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.categorieA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prixA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prixA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockA;
        private System.Windows.Forms.ComboBox categorieA;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Button enregistrerArt;
        private System.Windows.Forms.Button modifierArt;
        private System.Windows.Forms.Button supprimerArt;
        private Guna.UI.WinForms.GunaDataGridView dgvListArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listeArtParCat;
        private System.Windows.Forms.Button actualiserArt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label TextLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker dateExpiration;
        private System.Windows.Forms.TextBox codeArticle;
        private System.Windows.Forms.TextBox nomA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
    }
}