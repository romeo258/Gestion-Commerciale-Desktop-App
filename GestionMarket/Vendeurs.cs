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
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace GestionMarket
{
    public partial class Vendeurs : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;
        public Vendeurs()
        {
            InitializeComponent();
            cnx = new MySqlConnection(chaine);
            cnx.Open();
            ListerVendeur();
            pseudoV.Select();
        }

        private void Vendeurs_Load(object sender, EventArgs e)
        {

        }

        private void enregistrerVend_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomV.Text == "" || pseudoV.Text == "" || mdpV.Text == "" || adresseV.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "insert into vendeur values(@pseudo, @nom, @motPass, @adresse, @phone)";
                    cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@pseudo", pseudoV.Text);
                    cmd.Parameters.AddWithValue("@nom", nomV.Text);
                    cmd.Parameters.AddWithValue("@motPass", mdpV.Text);
                    cmd.Parameters.AddWithValue("@adresse", adresseV.Text);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber.Text);

                    cmd.ExecuteNonQuery();

                    ListerVendeur();
                    MessageBox.Show("Vendeur Ajouté!!!");

                    pseudoV.Text = "";
                    nomV.Text = "";
                    mdpV.Text = "";
                    adresseV.Text = "";
                    pseudoV.Select();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ListerVendeur()
        {
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select nom as 'NOM DU VENDEUR', pseudo as PSEUDO, motPass as 'MOT DE PASSE', phone as CONTACT, adresse as 'ADRESSE' from vendeur", cnx);
            da.Fill(ds, "vendeur");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvListVend.DataSource = view;


        }


        private void dgvListVend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nomV.Text = dgvListVend.SelectedRows[0].Cells[0].Value.ToString();
                pseudoV.Text = dgvListVend.SelectedRows[0].Cells[1].Value.ToString();
                mdpV.Text = dgvListVend.SelectedRows[0].Cells[2].Value.ToString();
                phoneNumber.Text = dgvListVend.SelectedRows[0].Cells[3].Value.ToString();
                adresseV.Text = dgvListVend.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void modifierVend_Click(object sender, EventArgs e)
        {
            try
            {
                if (pseudoV.Text == "" || nomV.Text == "" || mdpV.Text == "" || adresseV.Text == "" || nomV.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "update vendeur set pseudo=@pseudo2, nom=@nom, motPass=@motPass, phone=@phone, adresse=@adresse where pseudo=@pseudo";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@pseudo", pseudoV.Text);

                    cmd.Parameters.AddWithValue("@nom", nomV.Text);

                    cmd.Parameters.AddWithValue("@motPass", mdpV.Text);

                    cmd.Parameters.AddWithValue("@phone", phoneNumber.Text);

                    cmd.Parameters.AddWithValue("@adresse", adresseV.Text);

                    cmd.Parameters.AddWithValue("@pseudo2", newPseudo.Text);

                    cmd.ExecuteNonQuery();
                    ListerVendeur();
                    MessageBox.Show("Vendeur Modifié!!!");

                    pseudoV.Text = "";
                    nomV.Text = "";
                    mdpV.Text = "";
                    adresseV.Text = "";
                    newPseudo.Text = "";
                    pseudoV.Select();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        
        }

        private void SupprimerVend_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomV.Text == "" || pseudoV.Text == "" || mdpV.Text == "" || adresseV.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "delete from vendeur where pseudo=@pseudo";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@pseudo", pseudoV.Text);

                    cmd.ExecuteNonQuery();
                    ListerVendeur();
                    MessageBox.Show("Vendeur Supprimé!!!");

                    pseudoV.Text = "";
                    nomV.Text = "";
                    mdpV.Text = "";
                    adresseV.Text = "";

                    pseudoV.Select();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TextLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Connexion connex = new Connexion();
            connex.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
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

