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
        private float _actualPrice;
        private ObservableCollection<Offer> _offers;

        public bool OnCancel = false;
        #endregion

        #region Constructeur
        public UneEnchereClassiqueVueModele(Enchere enchere)
        {
            _enchere = enchere;
            Offers = new ObservableCollection<Offer>();

            tmps = new DecompteTimer();
            DateTime datefin = new DateTime(2022, 12, 13);
            TimeSpan interval = datefin - DateTime.Now;
            tmps.Start(interval);

            this.GetTimerRemaining();
            this.AfficherLastSixOffers();
            this.ThreadRefreshEnchere();
        }
        #endregion

        #region Properties
        public ObservableCollection<Offer> Offers
        {
            get => _offers;
            set => SetProperty(ref _offers, value);
        }
        public bool IsUserLogged
        {
            get => !Session.IsVisiter();
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

        public void ThreadRefreshEnchere()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    AfficherLastSixOffers();
                    RefreshActualPrice();
                    Thread.Sleep(1000);
                }
            });
        }

        public async void ThreadAutoEnchere(int plafond, int secondes)
        {
            await Task.Run(async () =>
            {
                while (plafond > ActualPrice + 1 && Session.IsLogged())
                {
                    Offer lastOffer = Offers.First();
                    if (!lastOffer.Pseudo.ToLower().Equals(Session.User.Pseudo.ToLower()) && lastOffer.PrixEnchere < ActualPrice + 1)
                    {
                        await APIEnchere.PostEncherir(ActualPrice + 1, Session.User, Enchere);
                    }
                    Thread.Sleep(secondes * 1000);
                }
            });
        }

        public async void RefreshEnchere()
        {
            this.Enchere = await APIEnchere.GetEnchere(this.Enchere.Id);
        }

        public async void AfficherLastSixOffers()
        {
            var tempOffers = await APIEnchere.GetLastSixOffer(Enchere.Id);
            var actuelOffers = this.Offers;
            if (tempOffers == null || actuelOffers == null) return;
            if (tempOffers.Count != actuelOffers.Count)
            {
                this.Offers = tempOffers;
            }
            else
            {
                for (int i = 0; i < tempOffers.Count; i++)
                {
                    if (tempOffers[i].Pseudo != actuelOffers[i].Pseudo ||
                        tempOffers[i].Photo != actuelOffers[i].Photo ||
                        tempOffers[i].PrixEnchere != actuelOffers[i].PrixEnchere)
                    {
                        this.Offers = tempOffers;
                        return;
                    }
                }
            }
        }

        public async void RefreshActualPrice()
        {
            Encherir encherePrix = await APIEnchere.GetActuelPrice(this.Enchere.Id);
            if (encherePrix != null) ActualPrice = encherePrix.PrixEnchere;
        }
        #endregion
    }
}
