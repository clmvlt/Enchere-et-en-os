using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class BoxFlash
    {
        #region Attributes
        private int _prix;
        private bool _visible;

        #endregion

        #region Constructeurs
        public BoxFlash(int prix, bool visible)
        {
            _prix = prix;
            _visible = visible;
        }

        #endregion

        #region Properties (Getters/Setters)
        public int Prix { get => _prix; set => _prix = value; }
        public bool Visible { get => _visible; set => _visible = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
