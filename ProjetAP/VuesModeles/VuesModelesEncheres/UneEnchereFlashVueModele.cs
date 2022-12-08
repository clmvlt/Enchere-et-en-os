using ProjetAP.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles.VuesModelesEncheres
{
    public class UneEnchereFlashVueModele : BaseVueModele
    {
        #region Attributes
        private Enchere _enchere;
        #endregion

        #region Constructeurs
        public UneEnchereFlashVueModele(Enchere enchere)
        {
            Enchere= enchere;
        }
        #endregion

        #region Properties (Getters/Setters)
        public Enchere Enchere
        {
            get => _enchere;
            set => SetProperty(ref _enchere, value);
        }
        #endregion

        #region Méthodes
        #endregion
    }
}
