using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmAjouterTraversee : Form
    {
        public frmAjouterTraversee()
        {
            InitializeComponent();
        }

        // Chargement des données
        private void frmAjouterTraversee_Load(object sender, EventArgs e)
        {
            dtpDateTraversee.MinDate = DateTime.Today;
            // Chargement des liaisons
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                requete = "select codeliaison, dep.nom, arr.nom from port arr, port dep, liaison where arr.idport = idport_arrivee and dep.idport = liaison.idport";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    liaison liaisonRetourne = new liaison((int)jeuEnr[0], (string)jeuEnr[1], (string)jeuEnr[2]);
                    cmbLiaison.Items.Add(liaisonRetourne);
                }
            }
            catch (NpgsqlException npgsqlEx)
            {
                MessageBox.Show("Erreur " + npgsqlEx.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Chargement des bateaux
            try
            {
                string requete;
                maCnx.Open();
                requete = "SELECT * FROM bateau";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    bateau bateauRetourne = new bateau((int)jeuEnr[0], (string)jeuEnr[1]);
                    cmbBateau.Items.Add(bateauRetourne);
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

        // Insertion d'une traversée
        private void btnAjouterTraversee_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                if (cmbLiaison.SelectedItem != null && cmbBateau.SelectedItem != null)
                {
                    string requete, codeLiaisonSelec, idBateauSelec;
                    NpgsqlCommand maCde;
                    maCnx.Open();
                    liaison liaisonSelec = (liaison)cmbLiaison.SelectedItem;
                    codeLiaisonSelec = liaisonSelec.getId().ToString();
                    bateau bateauSelec = (bateau)cmbBateau.SelectedItem;
                    idBateauSelec = bateauSelec.getId().ToString();
                    requete = "INSERT INTO traversee(codeliaison, idbateau, date, heure) VALUES (" + codeLiaisonSelec + "," + idBateauSelec + ",'"
                        + dtpDateTraversee.Value.ToString("yyyy-MM-dd") + "','" + dtpHeureTraversee.Value.ToString("HH:mm:ss") + "');";
                    maCde = new NpgsqlCommand(requete, maCnx);
                    maCde.ExecuteScalar();
                    MessageBox.Show("Traversée créee avec succès.", "Traversée créee", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Erreur: veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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