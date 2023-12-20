using MySql.Data.MySqlClient;
using System;
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
    public partial class FacturationForm : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;
        public FacturationForm()
        {
            InitializeComponent();
            cnx = new MySqlConnection(chaine);
            cnx.Open();
            remplirListePseudo();
            remplirListePseudo2();
            listeCompta();
            listeVente();


            listePeriodeVente.Items.Add("7 Derniers Jours");
            listePeriodeVente.Items.Add("30 Derniers Jours");

        }

        private void FacturationForm_Load(object sender, EventArgs e)
        {

        }

        private void remplirListePseudo()
        {
            cnx = new MySqlConnection(chaine);
            cnx.Open();

            string sql = "select pseudo from vendeur";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "pseudo");

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                listeVendeurVente.Items.Add(x[0].ToString());
            }
        }

        private void remplirListePseudo2()
        {
            cnx = new MySqlConnection(chaine);
            cnx.Open();

            string sql = "select pseudo from vendeur";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "pseudo");

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                listeVendCompta.Items.Add(x[0].ToString());
            }
        }

        private void actualiserPeriodeVente_Click(object sender, EventArgs e)
        {
            listeVente();
        }

        private void listeVendeurVente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select pseudo as PSEUDO, dateVente as 'DATE DE VENTE', montAntVente as MONTANT from facture where pseudo like @pseudo", cnx);
            da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendeurVente.Text + "%");
            da.Fill(ds, "facture");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvVente.DataSource = view;
        }

        private void listePeriodeVente_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listePeriodeVente.Text == "30 Derniers Jours")
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, dateVente as 'DATE DE VENTE', montAntVente as MONTANT from facture where pseudo like @pseudo and dateVente > (NOW() - INTERVAL 1 MONTH) ORDER BY montAntVente DESC", cnx);
                da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendeurVente.Text + "%");
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvVente.DataSource = view;
            }

            if (listePeriodeVente.Text == "7 Derniers Jours")
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, dateVente as 'DATE DE VENTE', montAntVente as MONTANT from facture where pseudo like @pseudo and dateVente > (NOW() - INTERVAL 1 WEEK) ORDER BY montAntVente DESC", cnx);
                da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendeurVente.Text + "%");
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvVente.DataSource = view;
            }
        }

        private void listeVendCompta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select pseudo as PSEUDO, SUM(montAntVente) as 'TOTAL DES VENTES' from facture where pseudo like @pseudo group by pseudo", cnx);
            da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendCompta.Text + "%");
            da.Fill(ds, "facture");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvCompta.DataSource = view;
        }

        private void periodeVenteCompta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (periodeVenteCompta.Text == "30 Derniers Jours")
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, SUM(montAntVente) as 'TOTAL DES VENTES' from facture where pseudo like @pseudo and dateVente > (NOW() - INTERVAL 1 MONTH) group by pseudo", cnx);
                da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendeurVente.Text + "%");
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvCompta.DataSource = view;
            }

            if (periodeVenteCompta.Text == "7 Derniers Jours")
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, SUM(montAntVente) as 'TOTAL DES VENTES' from facture where pseudo like @pseudo and dateVente > (NOW() - INTERVAL 1 WEEK) group by pseudo", cnx);
                da.SelectCommand.Parameters.AddWithValue("@pseudo", "%" + listeVendeurVente.Text + "%");
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvCompta.DataSource = view;
            }
        }

        private void actualiserCompta_Click(object sender, EventArgs e)
        {
            listeCompta();
        }

        private void listeCompta()
        {
            try
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, SUM(montAntVente) as 'TOTAL DES VENTES' from facture group by pseudo", cnx);
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvCompta.DataSource = view;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void listeVente()
        {
            try
            {
                ds = new DataSet();
                tables = ds.Tables;
                da = new MySqlDataAdapter("select pseudo as PSEUDO, dateVente as 'DATE DE VENTE', montAntVente as MONTANT from facture", cnx);
                da.Fill(ds, "facture");
                DataView view = new DataView(tables[0]);
                source1 = new BindingSource();
                source1.DataSource = view;
                dgvVente.DataSource = view;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FacturationForm Obj = new FacturationForm();
            Obj.Show();
            this.Hide();
        }
    }

    
}
