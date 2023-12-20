using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMarket
{
    public partial class Articles : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;

        public Articles()
        {

            InitializeComponent();
            cnx = new MySqlConnection(chaine);
            cnx.Open();
            ListerArticle();
            selectCategorie();
            remplirListeArtCategorie();
            nomA.Select();
        }

        private void ListerArticle()
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select codeArt as CODE, nomArt as LIBELLE, prixArt as 'PRIX DE VENTE', stockArt as QUANTITÉ, nomCat as CATEGORIE, dateExpArt as 'DATE EXPIRATION' from article where nomCat like @nomCat", cnx);
            da.SelectCommand.Parameters.AddWithValue("@nomCat", listeArtParCat.Text + "%");
            da.Fill(ds, "article");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvListArt.DataSource = view;


        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }

        private void enregistrerArt_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomA.Text == "" || prixA.Text == "" || categorieA.SelectedIndex == -1 || stockA.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "INSERT INTO article(nomArt, prixArt, stockArt, nomCat, dateExpArt) VALUES (@nomArt, @prixArt, @stockArt, @nomCat, @dateExpArt)";
                    cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@nomArt", nomA.Text);
                    cmd.Parameters.AddWithValue("@prixArt", int.Parse(prixA.Text));
                    cmd.Parameters.AddWithValue("@stockArt", int.Parse(stockA.Text));
                    cmd.Parameters.AddWithValue("@nomCat", categorieA.Text);
                    cmd.Parameters.AddWithValue("@dateExpArt", dateExpiration.Text);

                    cmd.ExecuteNonQuery();

                    ListerArticle();
                    MessageBox.Show("Article Ajouté!!!");

                    nomA.Text = "";
                    prixA.Text = "";
                    stockA.Text = "";
                    categorieA.Text = "";
                    dateExpiration.Text = "";
                    nomA.Select();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dateExpiration_ValueChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void dgvListArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codeArticle.Text = dgvListArt.SelectedRows[0].Cells[0].Value.ToString();
            nomA.Text = dgvListArt.SelectedRows[0].Cells[1].Value.ToString();
            prixA.Text = dgvListArt.SelectedRows[0].Cells[2].Value.ToString();
            categorieA.Text = dgvListArt.SelectedRows[0].Cells[4].Value.ToString();
            stockA.Text = dgvListArt.SelectedRows[0].Cells[3].Value.ToString();
            dateExpiration.Text = dgvListArt.SelectedRows[0].Cells[4].Value.ToString();

            if (nomA.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvListArt.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void supprimerArt_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Selectionnez un Article Svp!!!");
                }
                else
                {
                    string sql = "delete from article where nomArt=@nomArt";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@nomArt", nomA.Text);

                    cmd.ExecuteNonQuery();

                    ListerArticle();
                    MessageBox.Show("Article Supprimé!!!");

                    nomA.Text = "";
                    prixA.Text = "";
                    stockA.Text = "";
                    categorieA.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void modifierArt_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomA.Text == "" || prixA.Text == "" || categorieA.Text == "" || stockA.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "update article set nomArt=@nomArt, prixArt=@prixArt, stockArt=@stockArt, nomCat=@nomCat, dateExpArt=@dateExpArt where codeArt=@codeArt";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@nomArt", nomA.Text);

                    cmd.Parameters.AddWithValue("@prixArt", int.Parse(prixA.Text));

                    cmd.Parameters.AddWithValue("@stockArt", int.Parse(stockA.Text));

                    cmd.Parameters.AddWithValue("@nomCat", categorieA.Text);

                    cmd.Parameters.AddWithValue("@codeArt", int.Parse(codeArticle.Text));

                    cmd.Parameters.AddWithValue("@dateExpArt", dateExpiration.Text);

                    cmd.ExecuteNonQuery();

                    ListerArticle();
                    MessageBox.Show("Article Modifié!!!");

                    nomA.Text = "";
                    prixA.Text = "";
                    stockA.Text = "";
                    categorieA.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void selectCategorie()
        {
            cnx = new MySqlConnection(chaine);
            cnx.Open();

            string sql = "select nomCat from categorie";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "nomCat");

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                categorieA.Items.Add(x[0].ToString());
            }
        }

        private void remplirListeArtCategorie()
        {
            cnx = new MySqlConnection(chaine);
            cnx.Open();

            string sql = "select nomCat from categorie";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "nomCat");

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                listeArtParCat.Items.Add(x[0].ToString());
            }
        }

        private void actualiserArt_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select codeArt as CODE, nomArt as LIBELLE, prixArt as 'PRIX DE VENTE', stockArt as QUANTITÉ, nomCat as CATEGORIE, dateExpArt as 'DATE EXPIRATION' from article", cnx);
                da.Fill(ds, "article");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvListArt.DataSource = view;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void listeArtParCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListerArticle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void recherche()
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select codeArt as CODE, nomArt as LIBELLE, prixArt as 'PRIX DE VENTE', stockArt as QUANTITÉ, nomCat as CATEGORIE, dateExpArt as 'DATE EXPIRATION' from article where nomCat like @nomCat", cnx);
            da.SelectCommand.Parameters.AddWithValue("@nomCat", searchA.Text + "%");
            da.Fill(ds, "article");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvListArt.DataSource = view;
        }

        private void searchA_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select codeArt as CODE, nomArt as LIBELLE, prixArt as 'PRIX DE VENTE', stockArt as QUANTITÉ, nomCat as CATEGORIE, dateExpArt as 'DATE EXPIRATION' from article where nomArt like @nomArt", cnx);
            da.SelectCommand.Parameters.AddWithValue("@nomArt", "%" + searchA.Text + "%");
            da.Fill(ds, "article");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvListArt.DataSource = view;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FacturationForm Obj = new FacturationForm();
            Obj.Show();
            this.Hide();
        }
    }
}
