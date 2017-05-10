using System;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class frmRecapCommande : Form
    {
        public frmRecapCommande(string tNumTraversee, liaison tLiaison, string tDate, string tHeure, string tNumReservation, string[] tCoordonnees, int[] tTarifs,
            int[] tNbPlacesResrvees)
        {
            InitializeComponent();
            int montantTotal = 0;
            lblLiaison.Text = "Liaison " + tLiaison;
            lblTraverseeDateHeure.Text = "Traversée n°" + tNumTraversee + " le " + tDate + " à " + tHeure;
            lblNumReservation.Text = "Réservation enregistrée sous le n°" + tNumReservation;
            lblAdresse.Text = tCoordonnees[0] + " " + tCoordonnees[1] + " " + tCoordonnees[2] + " " + tCoordonnees[3];
            lblNbPlacesType1.Text = tNbPlacesResrvees[0].ToString();
            lblNbPlacesType2.Text = tNbPlacesResrvees[1].ToString();
            lblNbPlacesType3.Text = tNbPlacesResrvees[2].ToString();
            lblNbPlacesType4.Text = tNbPlacesResrvees[3].ToString();
            lblNbPlacesType5.Text = tNbPlacesResrvees[4].ToString();
            lblNbPlacesType6.Text = tNbPlacesResrvees[5].ToString();
            lblNbPlacesType7.Text = tNbPlacesResrvees[6].ToString();
            lblNbPlacesType8.Text = tNbPlacesResrvees[7].ToString();
            for (int i = 0; i <= 7; i++)
            {
                montantTotal = montantTotal + tTarifs[i] * tNbPlacesResrvees[i];
            }
            lblMontantTotal.Text = "Montant total à régler " + montantTotal.ToString() + "€";
        }
    }
}