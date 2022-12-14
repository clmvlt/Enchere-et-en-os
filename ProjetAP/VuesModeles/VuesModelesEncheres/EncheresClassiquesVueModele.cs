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
    public class EncheresClassiquesVueModele : BaseVueModele
    {
        #region Attribus
        private ObservableCollection<Enchere> _encheresEnCoursInversees;
        private ObservableCollection<Enchere> _encheresFutures;
        #endregion

        #region Constructeur
        public EncheresClassiquesVueModele()
        {
            AfficherLesEncheres();
        }
        #endregion

        #region Guetteurs Setteurs
        public ObservableCollection<Enchere> EncheresEnCours
        {
            get => _encheresEnCoursInversees;
            set => SetProperty(ref _encheresEnCoursInversees, value);
        }

        public ObservableCollection<Enchere> EncheresFutures
        {
            get => _encheresFutures;
            set => SetProperty(ref _encheresFutures, value);
        }
        #endregion

        #region Methode
        public async void AfficherLesEncheres()
        {
            EncheresEnCours = await APIEnchere.GetEncheresEnCours(1);
            EncheresFutures = await APIEnchere.GetEncheresFutures();
        }
        #endregion

    }
}
