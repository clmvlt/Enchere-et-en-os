using ProjetAP.Modeles;
using ProjetAP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles.VuesModelesEncheres
{
    public class EncheresFlashsVueModele : BaseVueModele
    {
        #region Attributes
        private ObservableCollection<Enchere> _encheresFlashs;
        #endregion

        #region Constructeurs
        public EncheresFlashsVueModele()
        {
            AfficherLesEncheres();
        }
        #endregion

        #region Properties (Getters/Setters)
        public ObservableCollection<Enchere> EncheresFlash
        {
            get => _encheresFlashs;
            set => SetProperty(ref _encheresFlashs, value);
        }
        #endregion

        #region Méthodes
        public async void AfficherLesEncheres()
        {
            EncheresFlash = await APIEnchere.GetEncheresEnCours(3);
        }
        #endregion
    }
}
