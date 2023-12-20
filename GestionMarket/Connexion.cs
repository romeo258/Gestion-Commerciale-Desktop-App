using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace GestionMarket
{
    public partial class Connexion : Form
    {
        MySqlConnection cnx;
        String chaine = "Database=gestionmarket2;Data Source=localhost; port=3308;User Id=root;Password=1234";
        MySqlDataAdapter da;
        DataSet ds;
        DataTableCollection tables;
        BindingSource source1;
        DataView view = new DataView();
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Connexion()
        {
            InitializeComponent();
        }

        public static int UserId;
        public static string UserName;
        private void connecter_Click(object sender, EventArgs e)
        {
            cnx = new MySqlConnection(chaine);
            cnx.Open();

            if (pseudoCnx.Text == "" || mdpCnx.Text == "")
            {
                MessageBox.Show("Entrez les informations Completes!!!");
            }
            else if (pseudoCnx.Text == "Admin" && mdpCnx.Text == "CaveRel@x258")
            {
                Articles Obj = new Articles();
                Obj.Show();
                this.Hide();

            }
            else
            {
                string sql = "SELECT * FROM vendeur WHERE pseudo = @pseudo and motPass=@motPass";
                cmd = new MySqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@pseudo", pseudoCnx.Text);
                cmd.Parameters.AddWithValue("@motPass", mdpCnx.Text);

                //cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            UserName = pseudoCnx.Text;
                            Factures Obj = new Factures();
                            Obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Vendeur Inexistant");
                        }
            }
            cnx.Close();

        }

        private void Connexion_Load(object sender, EventArgs e)
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

        private void mdpCnx_TextChanged(object sender, EventArgs e)
        {
            mdpCnx.PasswordChar = '*';
        }
    }
}
