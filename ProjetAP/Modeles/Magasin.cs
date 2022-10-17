using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class Magasin
    {
        #region Attribus
        private int _id;
        private string _nom;
        private string _adresse;
        private string _ville;
        private string _codePostal;
        private string _portable;
        private double _latitude;
        private double _longitude;

        #endregion

        #region Constructeur
        public Magasin(int id, string nom, string adresse, string ville, string codePostal, string portable, double latitude, double longitude)
        {
            _id = id;
            _nom = nom;
            _adresse = adresse;
            _ville = ville;
            _codePostal = codePostal;
            _portable = portable;
            _latitude = latitude;
            _longitude = longitude;
        }
        #endregion

        #region Guetteurs Setteurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public string CodePostal { get => _codePostal; set => _codePostal = value; }
        public string Portable { get => _portable; set => _portable = value; }
        public double Latitude { get => _latitude; set => _latitude = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
