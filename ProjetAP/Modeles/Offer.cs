using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class Offer
    {
        #region Attribus
        public static List<Offer> CollClasse = new List<Offer>();
        private float _prixEnchere;
        private string _pseudo;
        private string _photo;

        #endregion

        #region Constructeur
        public Offer(float prixEnchere, string pseudo, string photo)
        {
            PrixEnchere = prixEnchere;
            Pseudo = pseudo;
            Photo = photo;
            Offer.CollClasse.Add(this);
        }

        #endregion

        #region Properties
        public float PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public string Photo { get => _photo; set => _photo = value; }
        #endregion

        #region Methdoes
        #endregion
    }
}
