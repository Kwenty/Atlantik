using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmPrincipal : Form
    {
        public void chargementLiaison(ComboBox cmbLiaisonSecteur, string noSecteur)
        {
            NpgsqlConnection maCnx;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
            try
            {
                string requete;
                maCnx.Open();
                requete = "select codeliaison, dep.nom, arr.nom from port arr, port dep, liaison where arr.idport = idport_arrivee and dep.idport = liaison.idport" +
                    " and idsecteur=" + noSecteur;
                maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    liaison liaisonRetourne = new liaison((int)jeuEnr[0], (string)jeuEnr[1], (string)jeuEnr[2]);
                    cmbLiaisonSecteur.Items.Add(liaisonRetourne);
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

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void miCreerLiaison_Click(object sender, EventArgs e)
        {
            Form fenetreCreationLiaison = new frmCreerLiaison();
            fenetreCreationLiaison.ShowDialog();
        }

        private void miAjouterTraversee_Click(object sender, EventArgs e)
        {
            Form fenetreAjoutTraversee = new frmAjouterTraversee();
            fenetreAjoutTraversee.ShowDialog();
        }

        private void créerDesTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fenetreAjoutTarifs = new frmAjouterTarifs();
            fenetreAjoutTarifs.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dtpAix.MinDate = DateTime.Today;
            dtpBatz.MinDate = DateTime.Today;
            dtpBelleIleEnMer.MinDate = DateTime.Today;
            dtpBrehat.MinDate = DateTime.Today;
            dtpHouat.MinDate = DateTime.Today;
            dtpIleDeGroix.MinDate = DateTime.Today;
            dtpMolene.MinDate = DateTime.Today;
            dtpOuessant.MinDate = DateTime.Today;
            dtpSein.MinDate = DateTime.Today;
            dtpYeu.MinDate = DateTime.Today;

            // Chargement des liaisons
            chargementLiaison(cmbLiaisonAix, "1");
            chargementLiaison(cmbLiaisonBatz, "2");
            chargementLiaison(cmbLiaisonBelleIleEnMer, "3");
            chargementLiaison(cmbLiaisonBrehat, "4");
            chargementLiaison(cmbLiaisonHouat, "5");
            chargementLiaison(cmbLiaisonIleDeGroix, "6");
            chargementLiaison(cmbLiaisonMolene, "7");
            chargementLiaison(cmbLiaisonOuessant, "8");
            chargementLiaison(cmbLiaisonSein, "9");
            chargementLiaison(cmbLiaisonYeu, "10");
        }

        private void chargementListView(ComboBox cmbLieuLiaison, ListView lvLieu, DateTimePicker dtpSecteur)
        {
            int quantiteA = 0, quantiteB = 0, quantiteC = 0;
            if (cmbLieuLiaison.SelectedItem != null)
            {
                //Chargement du numero, de l'heure et du bateau de la traversée
                NpgsqlConnection maCnx;
                NpgsqlCommand maCde;
                NpgsqlDataReader jeuEnr = null;
                maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
                try
                {
                    maCnx.Open();
                    liaison liaisonSelec = (liaison)cmbLieuLiaison.SelectedItem;
                    string codeLiaisonSelec = liaisonSelec.getId().ToString();
                    string requete = "SELECT numtraversee, traversee.heure, bateau.libelle, capacitemax FROM traversee, bateau, contenir" +
                        " WHERE bateau.idbateau = traversee.idbateau AND contenir.idbateau = bateau.idbateau AND codeliaison = '" +
                        codeLiaisonSelec + "' AND date = '" + dtpSecteur.Value.ToString("yyyy-MM-dd") + "' ORDER BY numtraversee, lettrecategorie ASC";
                    maCde = new NpgsqlCommand(requete, maCnx);
                    jeuEnr = maCde.ExecuteReader();
                    lvLieu.Items.Clear();
                    while (jeuEnr.Read())
                    {
                        ListViewItem lviAjout = new ListViewItem();
                        lviAjout.Text = jeuEnr[0].ToString();
                        DateTime heure = (DateTime)jeuEnr[1];
                        lviAjout.SubItems.Add(heure.ToString("HH:mm"));
                        lviAjout.SubItems.Add(jeuEnr[2].ToString());
                        NpgsqlConnection maCnx2;
                        NpgsqlCommand maCde2;
                        NpgsqlDataReader jeuEnr2 = null;
                        maCnx2 = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=Postgres;Password=test;Database=atlantik;");
                        //Chargement des quantitées réservées sur les traversées
                        try
                        {
                            maCnx2.Open();
                            requete = "select sum(quantite) from enregistrer, type, reservation where enregistrer.numtype = type.numtype and lettrecategorie = 'A'" +
                                " and enregistrer.numreservation = reservation.numreservation and numtraversee = " + jeuEnr[0] + " union select sum(quantite) from enregistrer," +
                                " type, reservation where enregistrer.numtype = type.numtype and lettrecategorie = 'B' and" +
                                " enregistrer.numreservation = reservation.numreservation and numtraversee = " + jeuEnr[0] + " union select sum(quantite) from enregistrer," +
                                " type, reservation where enregistrer.numtype = type.numtype and lettrecategorie = 'C' and" +
                                " enregistrer.numreservation = reservation.numreservation and numtraversee = " + jeuEnr[0];
                            maCde2 = new NpgsqlCommand(requete, maCnx2);
                            jeuEnr2 = maCde2.ExecuteReader();
                            jeuEnr2.Read();
                            //Calcul des quantités restantes
                            if (jeuEnr2[0].ToString() != "")
                            {
                                quantiteA = Convert.ToInt32(jeuEnr[3]) - Convert.ToInt32(jeuEnr2[0]);
                            }
                            else
                            {
                                quantiteA = Convert.ToInt32(jeuEnr[3]);
                            }
                            jeuEnr.Read();
                            if (jeuEnr2.Read())
                            {
                                if (jeuEnr2[0].ToString() != "")
                                {
                                    quantiteB = Convert.ToInt32(jeuEnr[3]) - Convert.ToInt32(jeuEnr2[0]);
                                }
                                else
                                {
                                    quantiteB = Convert.ToInt32(jeuEnr[3]);
                                }
                                jeuEnr.Read();
                                if (jeuEnr2[0].ToString() != "" && jeuEnr2.Read())
                                {
                                    quantiteC = Convert.ToInt32(jeuEnr[3]) - Convert.ToInt32(jeuEnr2[0]);
                                }
                                else
                                {
                                    quantiteC = Convert.ToInt32(jeuEnr[3]);
                                }
                            }
                            else
                            {
                                quantiteB = Convert.ToInt32(jeuEnr[3]);
                                jeuEnr.Read();
                                quantiteC = Convert.ToInt32(jeuEnr[3]);
                            }
                        }
                        catch (NpgsqlException npgsqlEx)
                        {
                            MessageBox.Show("Erreur " + npgsqlEx.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (jeuEnr2 != null)
                            {
                                jeuEnr2.Close();
                            }
                            if (maCnx2 != null && maCnx2.State == ConnectionState.Open)
                            {
                                maCnx2.Close();
                            }
                        }
                        lviAjout.SubItems.Add(quantiteA.ToString());
                        lviAjout.SubItems.Add(quantiteB.ToString());
                        lviAjout.SubItems.Add(quantiteC.ToString());
                        lvLieu.Items.Add(lviAjout);
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
            else
            {
                MessageBox.Show("Erreur: veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reserverTraversee(ListView lvSecteur, ComboBox cmbLieuLiaison, DateTimePicker dtpSecteur)
        {
            if (lvSecteur.SelectedItems.Count != 0)
            {
                string date = dtpSecteur.Value.ToString("yyyy-MM-dd");
                liaison liaisonChoisie = (liaison)cmbLieuLiaison.SelectedItem;
                string noTraversee = lvSecteur.SelectedItems[0].Text.ToString();
                string heure = lvSecteur.SelectedItems[0].SubItems[1].Text.ToString();
                int maxTypeA = Convert.ToInt32(lvSecteur.SelectedItems[0].SubItems[3].Text);
                int maxTypeB = Convert.ToInt32(lvSecteur.SelectedItems[0].SubItems[4].Text);
                int maxTypeC = Convert.ToInt32(lvSecteur.SelectedItems[0].SubItems[5].Text);
                Form fenetreReservation = new frmReservation(maxTypeA, maxTypeB, maxTypeC, liaisonChoisie, date, heure, noTraversee);
                fenetreReservation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une liaison.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAix_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonAix, lvAix, dtpAix);
        }

        private void btnBatz_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonAix, lvAix, dtpAix);
        }

        private void btnBelleIleEnMer_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonBelleIleEnMer, lvBelleIleEnMer, dtpBelleIleEnMer);
        }

        private void btnBrehat_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonBrehat, lvBrehat, dtpBrehat);
        }

        private void btnHouat_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonHouat, lvHouat, dtpHouat);
        }

        private void btnIleDeGroix_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonIleDeGroix, lvIleDeGroix, dtpIleDeGroix);
        }

        private void btnMolene_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonMolene, lvMolene, dtpMolene);
        }

        private void btnOuessant_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonOuessant, lvOuessant, dtpOuessant);
        }

        private void btnSein_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonSein, lvSein, dtpSein);
        }

        private void btnYeu_Click(object sender, EventArgs e)
        {
            chargementListView(cmbLiaisonYeu, lvYeu, dtpYeu);
        }

        private void btnReserverAix_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvAix, cmbLiaisonAix, dtpAix);
        }

        private void btnReserverBatz_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvBatz, cmbLiaisonBatz, dtpBatz);
        }

        private void btnReserverBelleIleEnMer_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvBelleIleEnMer, cmbLiaisonBelleIleEnMer, dtpBelleIleEnMer);
        }

        private void btnReserverBrehat_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvBrehat, cmbLiaisonBrehat, dtpBrehat);
        }

        private void btnReserverHouat_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvHouat, cmbLiaisonHouat, dtpHouat);
        }

        private void btnReserverIleDeGroix_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvIleDeGroix, cmbLiaisonIleDeGroix, dtpIleDeGroix);
        }

        private void btnReserverMolene_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvMolene, cmbLiaisonMolene, dtpMolene);
        }

        private void btnReserverOuessant_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvOuessant, cmbLiaisonOuessant, dtpOuessant);
        }

        private void btnReserverSein_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvSein, cmbLiaisonSein, dtpSein);
        }

        private void btnReserverYeu_Click(object sender, EventArgs e)
        {
            reserverTraversee(lvYeu, cmbLiaisonYeu, dtpYeu);
        }
    }
}