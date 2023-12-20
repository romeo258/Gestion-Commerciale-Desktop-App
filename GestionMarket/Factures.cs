using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMarket
{
    public partial class Factures : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;
        public Factures()
        {
            InitializeComponent();
            cnx = new MySqlConnection(chaine);
            cnx.Open();
            ListerArticle();
            remplirListeArtCategorie();
        }

        private void ListerArticle()
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select codeArt as CODE, nomArt as ARTICLE, prixArt as 'PRIX', nomCat as CATEGORIE, stockArt as STOCK from article where nomCat like @nomCat", cnx);
            da.SelectCommand.Parameters.AddWithValue("@nomCat", listeArtParCat.Text + "%");
            da.Fill(ds, "article");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvArticleList.DataSource = view;
        }

        private void textlabel10_Load(object sender, EventArgs e)
        {
            vendeurLbl.Text = Connexion.UserName;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

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

        private void listeArtParCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListerArticle();
        }

        private void actualiserArt_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select codeArt as CODE, nomArt as ARTICLE, prixArt as PRIX, nomCat as CATEGORIE, stockArt as STOCK from article", cnx);
                da.Fill(ds, "article");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvArticleList.DataSource = view;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void searchA_TextChanged(object sender, EventArgs e)
        {
            
           ds = new DataSet();
           tables = ds.Tables;
           da = new MySqlDataAdapter("select codeArt as CODE, nomArt as ARTICLE, prixArt as 'PRIX', nomCat as CATEGORIE, stockArt as STOCK from article where nomArt like @nomArt", cnx);
           da.SelectCommand.Parameters.AddWithValue("@nomArt", "%" + searchA.Text + "%");
           da.Fill(ds, "article");
           DataView view = new DataView(tables[0]);
           source1 = new BindingSource();
           source1.DataSource = view;
           dgvArticleList.DataSource = view;
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pseudoV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void dgvArticleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            articleFac.Text = dgvArticleList.SelectedRows[0].Cells[1].Value.ToString();
            prixArtFac.Text = dgvArticleList.SelectedRows[0].Cells[2].Value.ToString();
            StockFac.Text = dgvArticleList.SelectedRows[0].Cells[4].Value.ToString();
            codeArtFac.Text = dgvArticleList.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void listeArtParCat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListerArticle();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }

        private void modifierVend_Click(object sender, EventArgs e)
        {
            codeArtFac.Text = "";
            prixArtFac.Text = "";
            StockFac.Text = "";
            quantiteFac.Text = "";
        }

        private void actualiserArt_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select codeArt as CODE, nomArt as ARTICLE, prixArt as 'PRIX', nomCat as CATEGORIE, stockArt as STOCK from article", cnx);
                da.Fill(ds, "article");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvArticleList.DataSource = view;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void modifierStock()
        {
            int stock = Convert.ToInt32(StockFac.Text);
            int newStock = stock - Convert.ToInt32(quantiteFac.Text);



            string sql = "update article set stockArt=@stockArt where codeArt=@codeArt";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@stockArt", newStock);
            cmd.Parameters.AddWithValue("@codeArt", codeArtFac.Text);

            cmd.ExecuteNonQuery();

            ListerArticle();
            
        }
        int n = 0;
        int GrdTotal = 0;
        private void enregistrerVend_Click(object sender, EventArgs e)
        {
            if (prixArtFac.Text == "" ||  quantiteFac.Text == "" || StockFac.Text == "" || codeArtFac.Text == "")
            {
                MessageBox.Show("Information Manquante!!!");
            }
            else
            {
                if (Convert.ToInt32(quantiteFac.Text) > Convert.ToInt32(StockFac.Text))
                {
                    MessageBox.Show("Nom Disponible!!!");
                }
                else
                {
                    int total = Convert.ToInt32(quantiteFac.Text) * Convert.ToInt32(prixArtFac.Text);
                    DataGridViewRow Ligne = new DataGridViewRow();
                    Ligne.CreateCells(dgvListFac);
                    Ligne.Cells[0].Value = n + 1;
                    Ligne.Cells[1].Value = articleFac.Text;
                    Ligne.Cells[2].Value = quantiteFac.Text;
                    Ligne.Cells[3].Value = prixArtFac.Text;
                    Ligne.Cells[4].Value = total;
                    dgvListFac.Rows.Add(Ligne);
                    GrdTotal = GrdTotal + total;
                    PrixTotal.Text = GrdTotal + " FCFA";

                    modifierStock();

                    codeArtFac.Text = "";
                    prixArtFac.Text = "";
                    StockFac.Text = "";
                    quantiteFac.Text = "";

                    n++;

                }
            }
        }

        private void searchA_TextChanged_1(object sender, EventArgs e)
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select codeArt as CODE, nomArt as ARTICLE, prixArt as PRIX, nomCat as CATEGORIE, stockArt as STOCK from article where nomArt like @nomArt", cnx);
            da.SelectCommand.Parameters.AddWithValue("@nomArt", "%" + searchA.Text + "%");
            da.Fill(ds, "article");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvArticleList.DataSource = view;
        }

        private void insererFacture()
        {
            int VenDeur = Connexion.UserId;

            string sql = "INSERT INTO facture VALUES (@pseudo, @dateVente, @montAntVente)";
            cmd = new MySqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@pseudo", Connexion.UserName);
            cmd.Parameters.AddWithValue("@dateVente", DateTime.Today.Date.ToString());
            cmd.Parameters.AddWithValue("@montAntVente", GrdTotal);

            cmd.ExecuteNonQuery();

            ListerArticle();
            MessageBox.Show("Facture Ajoutée!!!");
        }
        private void imprimerFac_Click(object sender, EventArgs e)
        {
            insererFacture();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int Code, Prix, Qte, Total;

        private void myname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        string Nom;
        int pos = 60;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CAVE RELAX", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(85));
            e.Graphics.DrawString("ID ARTICLE         PRIX    QTE          TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 40));

            foreach (DataGridViewRow row in dgvListFac.Rows)
            {
                Code = Convert.ToInt32(row.Cells["Column1"].Value);
                Nom = "" + row.Cells["Column2"].Value;
                Qte = Convert.ToInt32(row.Cells["Column3"].Value);
                Prix = Convert.ToInt32(row.Cells["Column4"].Value);
                Total = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + Code, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(10, pos));
                e.Graphics.DrawString("" + Nom, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(30, pos));
                e.Graphics.DrawString("" + Prix, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString("" + Qte, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString("" + Total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));

                pos = pos + 20;
            }
            e.Graphics.DrawString("À PAYER :  " + GrdTotal + " FCFA",new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(65, pos + 50));
            e.Graphics.DrawString("******FEUDJI EXPRESS*******",new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(35, pos + 80));
            dgvListFac.Rows.Clear();
            dgvListFac.Refresh();

            pos = 100;
            GrdTotal = 0;
            n = 0;
            PrixTotal.Text = "";
         }
    }
}
