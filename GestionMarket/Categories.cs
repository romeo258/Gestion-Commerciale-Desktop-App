using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GestionMarket
{
        
    public partial class Categories : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;


        public Categories()
        {
            InitializeComponent();
            cnx = new MySqlConnection(chaine);
            cnx.Open();
            ListerCategories();
        }

        private void ListerCategories()
        {

            
            ds = new DataSet();
            tables = ds.Tables;
            da = new MySqlDataAdapter("select nomCat as 'NOM DE LA CTEGORIE', remCat as REMARQUE from categorie", cnx);
            da.Fill(ds, "categorie");
            DataView view = new DataView(tables[0]);
            source1 = new BindingSource();
            source1.DataSource = view;
            dgvListCat.DataSource = view;
            

        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void enregistrerCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomC.Text == "" || remarqueC.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {

                    string sql = "INSERT INTO categorie VALUES(@nomCat, @remCat)";
                    cmd = new MySqlCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@nomCat", nomC.Text);
                    cmd.Parameters.AddWithValue("@remCat", remarqueC.Text);

                    cmd.ExecuteNonQuery();
                    ListerCategories();
                    MessageBox.Show("Categorie Ajoutée!!!");

                    nomC.Text = "";
                    remarqueC.Text = "";
                    
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void dgvListCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void modifierCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomC.Text == "" || remarqueC.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "update categorie set nomCat=@valm, remCat=@remCat where nomCat=@nomCat";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@nomCat", nomC.Text);

                    cmd.Parameters.AddWithValue("@remCat", remarqueC.Text);

                    cmd.Parameters.AddWithValue("@valm", valModif.Text);

                    cmd.ExecuteNonQuery();
                    ListerCategories();
                    MessageBox.Show("Categorie Modifiée!!!");

                    nomC.Text = "";
                    remarqueC.Text = "";
                    valModif.Text = "";
                    
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SupprimerCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomC.Text == "" || remarqueC.Text == "")
                {
                    MessageBox.Show("Completer le Formulaire Svp!!!");
                }
                else
                {
                    string sql = "delete from categorie where nomCat=@nomCat";
                    MySqlCommand cmd = new MySqlCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@nomCat", nomC.Text);

                    cmd.ExecuteNonQuery();
                    ListerCategories();
                    MessageBox.Show("Categorie Supprimée!!!");

                    nomC.Text = "";
                    remarqueC.Text = "";
                    valModif.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dgvListCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListCat.CurrentRow.Index != -1)
            {
                nomC.Text = dgvListCat.CurrentRow.Cells[0].Value.ToString();
                remarqueC.Text = dgvListCat.CurrentRow.Cells[1].Value.ToString();
                

               modifierCat.Enabled = true;
               SupprimerCat.Enabled = true;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
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
