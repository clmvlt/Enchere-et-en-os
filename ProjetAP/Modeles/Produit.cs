using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class Produit
    {
        #region Attribus
        private int _id;
        private string _nom;
        private string _photo;
        private int _prixReel;

        #endregion

        #region Constructeur
        public Produit(int id, string nom, string photo, int prixReel)
        {
            this._id = id;
            this._nom = nom;
            this._photo = photo;
            this._prixReel = prixReel;
        }

        #endregion

        #region Guetteurs Setteurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public int PrixReel { get => _prixReel; set => _prixReel = value; }
        #endregion

        #region Methode
        #endregion
    }
}
