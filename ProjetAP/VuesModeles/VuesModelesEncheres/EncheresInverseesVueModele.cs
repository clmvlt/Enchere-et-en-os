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
    public class EncheresInverseesVueModele : BaseVueModele
    {
        #region Attribus
        private ObservableCollection<Enchere> _encheresEnCoursInversees;
        #endregion

        #region Constructeur
        public EncheresInverseesVueModele()
        {
            AfficherLesEncheres();
        }
        #endregion

        #region Guetteurs Setteurs
        public ObservableCollection<Enchere> EncheresEnCoursInversees
        {
            get => _encheresEnCoursInversees;
            set => SetProperty(ref _encheresEnCoursInversees, value);
        }
        #endregion

        #region Methode
        public async void AfficherLesEncheres()
        {
            EncheresEnCoursInversees = await APIEnchere.GetEncheresEnCours(2);
        }
        #endregion
    }
}
