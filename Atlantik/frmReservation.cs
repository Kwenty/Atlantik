using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmReservation : Form
    {
        private int maxTypeA, maxTypeB, maxTypeC;
        private string noTraversee, date, heure, numReservation;
        private liaison liaisonChoisie;

        public frmReservation(int tMaxTypeA, int tMaxTypeB, int tMaxTypeC, liaison tLiaisonChoisie, string tDate, string tHeure, string tNoTraversee)
        {
            InitializeComponent();
            lblLiaison.Text = "Liaison " + tLiaisonChoisie;
            lblNumeroDateHeure.Text = "Traversée n°" + tNoTraversee + " le " + tDate + " à " + tHeure;
            liaisonChoisie = tLiaisonChoisie;
            noTraversee = tNoTraversee;
            date = tDate;
            heure = tHeure;
            maxTypeA = tMaxTypeA;
            maxTypeB = tMaxTypeB;
            maxTypeC = tMaxTypeC;
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                requete = "SELECT tarif FROM tarifer, periode WHERE tarifer.datedeb = periode.datedeb AND '" + tDate + "' > periode.datedeb AND '" +
                    tDate + "' < datefin ORDER BY numtype ASC";
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                if (jeuEnr.HasRows)
                {
                    jeuEnr.Read();
                    lblTarifType1.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType2.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType3.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType4.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType5.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType6.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType7.Text = jeuEnr[0].ToString();
                    jeuEnr.Read();
                    lblTarifType8.Text = jeuEnr[0].ToString();
                    btnReserver.Visible = true;
                    gbxCoordonnees.Visible = true;
                }
                else
                {
                    lblTarifType1.Text = "Aucun tarif";
                    lblTarifType2.Text = "Aucun tarif";
                    lblTarifType3.Text = "Aucun tarif";
                    lblTarifType4.Text = "Aucun tarif";
                    lblTarifType5.Text = "Aucun tarif";
                    lblTarifType6.Text = "Aucun tarif";
                    lblTarifType7.Text = "Aucun tarif";
                    lblTarifType8.Text = "Aucun tarif";
                }
                nudType1.Maximum = maxTypeA;
                nudType2.Maximum = maxTypeA;
                nudType3.Maximum = maxTypeA;
                nudType4.Maximum = maxTypeB;
                nudType5.Maximum = maxTypeB;
                nudType6.Maximum = maxTypeC;
                nudType7.Maximum = maxTypeC;
                nudType8.Maximum = maxTypeC;
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

        private void majMaxTypeA()
        {
            nudType1.Maximum = maxTypeA - nudType1.Value - nudType2.Value - nudType3.Value;
            nudType2.Maximum = maxTypeA - nudType1.Value - nudType2.Value - nudType3.Value;
            nudType3.Maximum = maxTypeA - nudType1.Value - nudType2.Value - nudType3.Value;
        }

        private void majMaxTypeB()
        {
            nudType4.Maximum = maxTypeB - nudType4.Value - nudType5.Value;
            nudType5.Maximum = maxTypeB - nudType4.Value - nudType5.Value;
        }

        private void majMaxTypeC()
        {
            nudType6.Maximum = maxTypeC - nudType6.Value - nudType7.Value - nudType8.Value;
            nudType7.Maximum = maxTypeC - nudType6.Value - nudType7.Value - nudType8.Value;
            nudType8.Maximum = maxTypeC - nudType6.Value - nudType7.Value - nudType8.Value;
        }

        private void nudType1_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeA();
        }

        private void nudType2_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeA();
        }

        private void nudType3_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeA();
        }

        private void nudType4_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeB();
        }

        private void nudType5_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeB();
        }

        private void nudType6_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeC();
        }

        private void nudType7_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeC();
        }

        private void nudType8_ValueChanged(object sender, EventArgs e)
        {
            majMaxTypeC();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            // Vérification des textBox
            string pattern = @"^([a-zA-Z]+)(\s)?([a-zA-Z]*)", pattern2 = "^[0-9]{5}$";
            Match m1 = Regex.Match(tbxNom.Text, pattern, RegexOptions.IgnoreCase);
            Match m2 = Regex.Match(tbxAdresse.Text, pattern, RegexOptions.IgnoreCase);
            Match m3 = Regex.Match(tbxCodePostal.Text, pattern2, RegexOptions.IgnoreCase);
            Match m4 = Regex.Match(tbxVille.Text, pattern, RegexOptions.IgnoreCase);
            if (m1.Success && m2.Success && m3.Success && m4.Success && (nudType1.Value != 0 || nudType2.Value != 0 || nudType3.Value != 0 || nudType4.Value != 0 || nudType5.Value != 0 || nudType6.Value != 0 || nudType7.Value != 0 || nudType8.Value != 0))
            {
                tbxVille.BackColor = Color.White;
                tbxNom.BackColor = Color.White;
                tbxCodePostal.BackColor = Color.White;
                tbxAdresse.BackColor = Color.White;
                NpgsqlConnection maCnx;
                maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
                // Insertion coordonnées
                try
                {
                    string requete;
                    NpgsqlCommand maCde;
                    maCnx.Open();
                    requete = "INSERT INTO reservation(numtraversee, nom, adr, cp, ville) VALUES('" + noTraversee + "','" + tbxNom.Text + "','" + tbxAdresse.Text + "','" +
                        tbxCodePostal.Text + "','" + tbxVille.Text + "') RETURNING numreservation";
                    //// Insertion places
                    maCde = new NpgsqlCommand(requete, maCnx);
                    numReservation = maCde.ExecuteScalar().ToString();
                    requete = "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(1," + numReservation + "," + nudType1.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(2," + numReservation + "," + nudType2.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(3," + numReservation + "," + nudType3.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(4," + numReservation + "," + nudType4.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(5," + numReservation + "," + nudType5.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(6," + numReservation + "," + nudType6.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(7," + numReservation + "," + nudType7.Value.ToString() + ");" +
                         "INSERT INTO enregistrer(numtype, numreservation, quantite) VALUES(8," + numReservation + "," + nudType8.Value.ToString() + ");";
                    maCde = new NpgsqlCommand(requete, maCnx);
                    maCde.ExecuteScalar();
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
            else
            {
                if (!m1.Success) { tbxNom.BackColor = Color.Red; } else { tbxNom.BackColor = Color.White; }
                if (!m2.Success) { tbxAdresse.BackColor = Color.Red; } else { tbxAdresse.BackColor = Color.White; }
                if (!m3.Success) { tbxCodePostal.BackColor = Color.Red; } else { tbxCodePostal.BackColor = Color.White; }
                if (!m4.Success) { tbxVille.BackColor = Color.Red; } else { tbxVille.BackColor = Color.White; }
                MessageBox.Show("Erreur: veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
            string[] coordonnees = new string[] { tbxNom.Text, tbxAdresse.Text, tbxCodePostal.Text, tbxVille.Text };
            int[] tarifs = new int[] 
            {
                Convert.ToInt32(lblTarifType1.Text),
                Convert.ToInt32(lblTarifType2.Text),
                Convert.ToInt32(lblTarifType3.Text),
                Convert.ToInt32(lblTarifType4.Text),
                Convert.ToInt32(lblTarifType5.Text),
                Convert.ToInt32(lblTarifType6.Text),
                Convert.ToInt32(lblTarifType7.Text),
                Convert.ToInt32(lblTarifType8.Text)
            };
            int[] nbPlacesReservees = new int[]
            {
                (int)nudType1.Value,
                (int)nudType2.Value,
                (int)nudType3.Value,
                (int)nudType4.Value,
                (int)nudType5.Value,
                (int)nudType6.Value,
                (int)nudType7.Value,
                (int)nudType8.Value,
            };
            frmRecapCommande fenetreRecapCommande = new frmRecapCommande(noTraversee, liaisonChoisie, date, heure, numReservation, coordonnees, tarifs, nbPlacesReservees);
            fenetreRecapCommande.Show();
        }
    }
}