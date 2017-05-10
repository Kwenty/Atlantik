using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmCreerLiaison : Form
    {
        public frmCreerLiaison()
        {
            InitializeComponent();
        }
        // Chargement données
        private void FrmCreerLiaison_Load(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                requete = "SELECT * FROM port";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int idPort = (int)jeuEnr[0];
                    string nomPort = (string)jeuEnr[1];
                    port portRetourne = new port(idPort, nomPort);
                    cmbPortArrivee.Items.Add(portRetourne);
                    cmbPortDepart.Items.Add(portRetourne);
                }
            }
            catch (NpgsqlException npgsqlEx)
            {
                Console.WriteLine("Erreur " + npgsqlEx.ToString());
            }
            finally
            {
                if (jeuEnr != null)
                {
                    jeuEnr.Close();
                }
                if (maCnx != null && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            try
            {
                string requete;
                maCnx.Open();
                requete = "SELECT * FROM secteur";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    int idSecteur = (int)jeuEnr[0];
                    string nomSecteur = (string)jeuEnr[1];
                    secteur secteutRetourne = new secteur(idSecteur, nomSecteur);
                    cmbSecteur.Items.Add(secteutRetourne);
                }
            }
            catch (NpgsqlException npgsqlEx)
            {
                Console.WriteLine("Erreur " + npgsqlEx.ToString());
            }
            finally
            {
                if (jeuEnr != null)
                {
                    jeuEnr.Close();
                }
                if (maCnx != null && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        // Création de la liaison
        private void btnCreerLiaison_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string pattern = "\\d+(\\.\\d{1,2})?";
                Match m = Regex.Match(tbxDistance.Text, pattern, RegexOptions.IgnoreCase);
                if (m.Success && cmbPortDepart.SelectedItem != null && cmbPortArrivee.SelectedItem != null && cmbSecteur.SelectedItem != null)
                {
                    string requete, portDepartIdSelec, portArriveeIdSelec, secteurIdSelec;
                    port portDepartSelec, portArriveeSelec;
                    secteur secteurSelec;
                    NpgsqlCommand maCde;
                    maCnx.Open();
                    portDepartSelec = (port)cmbPortDepart.SelectedItem;
                    portDepartIdSelec = portDepartSelec.getId().ToString();
                    portArriveeSelec = (port)cmbPortArrivee.SelectedItem;
                    portArriveeIdSelec = portArriveeSelec.getId().ToString();
                    secteurSelec = (secteur)cmbSecteur.SelectedItem;
                    secteurIdSelec = secteurSelec.getId().ToString();
                    requete = "INSERT INTO liaison(idport, idsecteur, idport_arrivee, distance) VALUES(" + portDepartIdSelec + ", " + secteurIdSelec + ", " + portArriveeIdSelec + ", " + tbxDistance.Text + ")";
                    maCde = new NpgsqlCommand(requete, maCnx);
                    maCde.ExecuteScalar();
                    tbxDistance.BackColor = Color.White;
                    tbxDistance.Text = "";
                }
                else
                {
                    tbxDistance.BackColor = Color.Red;
                    MessageBox.Show("Erreur: veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NpgsqlException npgEx)
            {
                MessageBox.Show("Erreur " + npgEx.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx != null && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
    }
}