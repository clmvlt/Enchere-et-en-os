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
    public class UneEnchereInverseeVueModele : BaseVueModele
    {
        #region Attributes
        private Enchere _enchere;

        private DecompteTimer tmps;
        private int _tempsRestantJour;
        private int _tempsRestantHeures;
        private int _tempsRestantMinutes;
        private int _tempsRestantSecondes;
        private float _actualPrice;
        private ObservableCollection<Offer> _offers;

        public bool OnCancel = false;
        #endregion

        #region Constructeurs
        public UneEnchereInverseeVueModele(Enchere enchere)
        {
            Enchere = enchere;
            Offers = new ObservableCollection<Offer>();

            tmps = new DecompteTimer();
            DateTime datefin = new DateTime(2022, 12, 13);
            TimeSpan interval = datefin - DateTime.Now;
            tmps.Start(interval);

            this.GetTimerRemaining();
            this.ThreadRefreshEnchere();
        }
        #endregion

        #region Properties (Getters/Setters)

        public bool IsUserLogged
        {
            get => !Session.IsVisiter();
        }
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
        public float ActualPrice
        {
            get { return _actualPrice; }
            set { SetProperty(ref _actualPrice, value); }
        }
        #endregion

        #region Méthodes
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

        public void ThreadRefreshEnchere()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    RefreshActualPrice();
                    Thread.Sleep(1000);
                }
            });
        }

        public async void RefreshEnchere()
        {
            this.Enchere = await APIEnchere.GetEnchere(this.Enchere.Id);
        }

        public async void RefreshActualPrice()
        {
            Encherir encherePrix = await APIEnchere.GetActuelPrice(this.Enchere.Id);
            if (encherePrix != null) ActualPrice = encherePrix.PrixEnchere;
        }
        #endregion
    }
}
