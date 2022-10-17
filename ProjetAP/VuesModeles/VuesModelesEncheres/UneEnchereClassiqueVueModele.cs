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
    public class UneEnchereClassiqueVueModele : BaseVueModele
    {
        #region Attribus
        private Enchere _enchere;

        private DecompteTimer tmps;
        private int _tempsRestantJour;
        private int _tempsRestantHeures;
        private int _tempsRestantMinutes;
        private int _tempsRestantSecondes;
        private ObservableCollection<Offer> _offers;

        public bool OnCancel = false;
        #endregion

        #region Constructeur
        public UneEnchereClassiqueVueModele(Enchere enchere)
        {
            _enchere = enchere;

            tmps = new DecompteTimer();
            DateTime datefin = new DateTime(2022, 12, 13);
            TimeSpan interval = datefin - DateTime.Now;
            tmps.Start(interval);

            this.GetTimerRemaining();
            this.AfficherLastSixOffers();
        }
        #endregion

        #region Properties
        public ObservableCollection<Offer> Offers
        {
            get => _offers;
            set => SetProperty(ref _offers, value);
        }
        public Enchere Enchere
        {
            get => _enchere;
            set => SetProperty(ref _enchere, value);
        }
        public int TempsRestantHeures
        {
            get { return _tempsRestantHeures; }
            set { SetProperty(ref _tempsRestantHeures, value); }
        }
        public int TempsRestantJour
        {
            get { return _tempsRestantJour; }
            set { SetProperty(ref _tempsRestantJour, value); }
        }
        public int TempsRestantMinutes
        {
            get { return _tempsRestantMinutes; }
            set { SetProperty(ref _tempsRestantMinutes, value); }
        }
        public int TempsRestantSecondes
        {
            get { return _tempsRestantSecondes; }
            set { SetProperty(ref _tempsRestantSecondes, value); }
        }
        #endregion

        #region Methodes
        public void GetTimerRemaining()
        {

            Task.Run(() =>
            {

                while (OnCancel == false)
                {
                    TempsRestantJour = tmps.TempsRestant.Days;
                    TempsRestantHeures = tmps.TempsRestant.Hours;
                    TempsRestantMinutes = tmps.TempsRestant.Minutes;
                    TempsRestantSecondes = tmps.TempsRestant.Seconds;

                    if (tmps.TempsRestant <= TimeSpan.Zero)
                    {
                        OnCancel = true;
                    }
                }

            });


        }

        private async void AfficherLastSixOffers()
        {
            Offers = await APIEnchere.GetLastSixOffer(Enchere.Id);
        }
        #endregion
    }
}
