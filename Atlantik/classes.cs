using System;

namespace Atlantik
{
    public class liaison
    {
        private int idLiaison;
        private string portDepart, portArrivee;

        public liaison(int idLiaison, string portDepart, string portArrivee)
        {
            this.idLiaison = idLiaison;
            this.portDepart = portDepart;
            this.portArrivee = portArrivee;
        }

        public int getId()
        {
            return idLiaison;
        }

        public override string ToString()
        {
            return portDepart + " - " + portArrivee;
        }
    }

    public class port
    {
        private int idPort;
        private string nom;

        public port(int idPort, string nom)
        {
            this.idPort = idPort;
            this.nom = nom;
        }

        public int getId()
        {
            return idPort;
        }

        public string getNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }

    public class secteur
    {
        private int idSecteur;
        private string nom;

        public secteur(int idSecteur, string nom)
        {
            this.idSecteur = idSecteur;
            this.nom = nom;
        }

        public int getId()
        {
            return idSecteur;
        }

        public override string ToString()
        {
            return nom;
        }
    }

    public class bateau
    {
        private int idBateau;
        private string nom;

        public bateau(int idBateau, string nom)
        {
            this.idBateau = idBateau;
            this.nom = nom;
        }

        public int getId()
        {
            return idBateau;
        }

        public override string ToString()
        {
            return nom;
        }
    }

    public class periode
    {
        private DateTime dateDeb, dateFin;

        public periode(DateTime dateDeb, DateTime dateFin)
        {
            this.dateDeb = dateDeb;
            this.dateFin = dateFin;
        }

        public string getDateDeb()
        {
            return dateDeb.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return dateDeb.ToString("yyyy-MM-dd") + " - " + dateFin.ToString("yyyy-MM-dd");
        }
    }
}