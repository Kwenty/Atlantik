using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmAjouterTarifs : Form
    {
        public frmAjouterTarifs()
        {
            InitializeComponent();
        }

        private void chargementLiaisons()
        {
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                periode periodeChoisie = (periode)cmbPeriode.SelectedItem;
                string dateDebPeriodeChoisie = periodeChoisie.getDateDeb();
                requete = "SELECT codeliaison, dep.nom, arr.nom FROM periode, port arr, port dep, liaison "
                    + "WHERE liaison.codeliaison NOT IN (SELECT codeliaison FROM tarifer WHERE dateDeb = '" + dateDebPeriodeChoisie + "') "
                    + "AND arr.idport = idport_arrivee and dep.idport = liaison.idport AND dateDeb = '" + dateDebPeriodeChoisie + "'";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                cmbLiaison.Items.Clear();
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
        }

        // Charge les périodes
        private void frmAjouterTarifs_Load(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                requete = "SELECT * FROM periode ORDER BY dateDeb ASC";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    periode periodeRetourne = new periode((DateTime)jeuEnr[0], (DateTime)jeuEnr[1]);
                    cmbPeriode.Items.Add(periodeRetourne);
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
        }

        // Charge les liaisons correspondantes
        private void cmbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementLiaisons();
        }

        // Insère les tarifs
        private void btnAjoutTarif_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                // Vérification des textBox
                string pattern = "\\d+(\\.\\d{1,2})?";
                Match m1 = Regex.Match(tbxType1.Text, pattern, RegexOptions.IgnoreCase);
                Match m2 = Regex.Match(tbxType2.Text, pattern, RegexOptions.IgnoreCase);
                Match m3 = Regex.Match(tbxType3.Text, pattern, RegexOptions.IgnoreCase);
                Match m4 = Regex.Match(tbxType4.Text, pattern, RegexOptions.IgnoreCase);
                Match m5 = Regex.Match(tbxType5.Text, pattern, RegexOptions.IgnoreCase);
                Match m6 = Regex.Match(tbxType6.Text, pattern, RegexOptions.IgnoreCase);
                Match m7 = Regex.Match(tbxType7.Text, pattern, RegexOptions.IgnoreCase);
                Match m8 = Regex.Match(tbxType8.Text, pattern, RegexOptions.IgnoreCase);
                if (m1.Success && m2.Success && m3.Success && m4.Success && m5.Success && m6.Success && m7.Success && m8.Success && cmbPeriode.SelectedItem != null && cmbLiaison.SelectedItem != null)
                {
                    tbxType1.BackColor = Color.White;
                    tbxType2.BackColor = Color.White;
                    tbxType3.BackColor = Color.White;
                    tbxType4.BackColor = Color.White;
                    tbxType5.BackColor = Color.White;
                    tbxType6.BackColor = Color.White;
                    tbxType7.BackColor = Color.White;
                    tbxType8.BackColor = Color.White;

                    // Insertion
                    string requete, dateDebPeriodeSelec, codeLiaisonSelec;
                    NpgsqlCommand maCde;
                    maCnx.Open();
                    periode periodeSelec = (periode)cmbPeriode.SelectedItem;
                    dateDebPeriodeSelec = periodeSelec.getDateDeb();
                    liaison liaisonSelec = (liaison)cmbLiaison.SelectedItem;
                    codeLiaisonSelec = liaisonSelec.getId().ToString();
                    requete = "INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',1," + tbxType1.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',2," + tbxType2.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',3," + tbxType3.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',4," + tbxType4.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',5," + tbxType5.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',6," + tbxType6.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',7," + tbxType7.Text + ");" +
                        " INSERT INTO tarifer(codeliaison, datedeb, numtype, tarif) VALUES (" + codeLiaisonSelec + ",'" + dateDebPeriodeSelec + "',8," + tbxType8.Text + ");";
                    maCde = new NpgsqlCommand(requete, maCnx);
                    maCde.ExecuteScalar();
                    tbxType1.Text = "";
                    tbxType2.Text = "";
                    tbxType3.Text = "";
                    tbxType4.Text = "";
                    tbxType5.Text = "";
                    tbxType6.Text = "";
                    tbxType7.Text = "";
                    tbxType8.Text = "";
                    cmbLiaison.Text = "";
                    chargementLiaisons();
                }
                else
                {
                    if (!m1.Success) { tbxType1.BackColor = Color.Red; } else { tbxType1.BackColor = Color.White; }
                    if (!m2.Success) { tbxType2.BackColor = Color.Red; } else { tbxType2.BackColor = Color.White; }
                    if (!m3.Success) { tbxType3.BackColor = Color.Red; } else { tbxType3.BackColor = Color.White; }
                    if (!m4.Success) { tbxType4.BackColor = Color.Red; } else { tbxType4.BackColor = Color.White; }
                    if (!m5.Success) { tbxType5.BackColor = Color.Red; } else { tbxType5.BackColor = Color.White; }
                    if (!m6.Success) { tbxType6.BackColor = Color.Red; } else { tbxType6.BackColor = Color.White; }
                    if (!m7.Success) { tbxType7.BackColor = Color.Red; } else { tbxType7.BackColor = Color.White; }
                    if (!m8.Success) { tbxType8.BackColor = Color.Red; } else { tbxType8.BackColor = Color.White; }
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