using ProjetAP.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles.VuesModelesEncheres
{
    public class UneEnchereClassiqueVueModele : BaseVueModele
    {
        #region Attribus
        private Enchere _enchere;
        #endregion

        #region Constructeur
        public UneEnchereClassiqueVueModele(Enchere enchere)
        {
            _enchere = enchere;
        }
        #endregion

        #region Properties
        public Enchere Enchere
        {
            get => _enchere;
            set => SetProperty(ref _enchere, value);
        }
        #endregion

        #region Methodes
        #endregion
    }
}
