using ProjetAP.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Services
{
    public static class APIEnchere
    {
        #region Attributs
        private static readonly Api _apiServices = new Api();
        #endregion

        #region Constructeurs
        #endregion

        #region Getters/Setters
        #endregion

        #region Methodes
        public static async Task<ObservableCollection<Enchere>> GetEncheresEnCours(int idtype)
        {
            var res = await _apiServices.GetAllAsyncID<Enchere>("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", idtype);
            Enchere.CollClasse.Clear();
            return res;
        }

        public static async Task<Enchere> GetEnchere(int id)
        {
            var res = await _apiServices.GetAllAsyncID<Enchere>("api/getEncheresEnCours", Enchere.CollClasse, "Id", id);
            Enchere.CollClasse.Clear();
            return res.First();
        }

        public static async Task<Encherir> GetActuelPrice(int id)
        {
            return await _apiServices.GetOneAsyncID<Encherir>("api/getActualPrice", id.ToString());
        }

        public static async Task<ObservableCollection<Enchere>> GetEncheresFutures()
        {
            var res = await _apiServices.GetAllAsync<Enchere>("api/getEncheresFutures", Enchere.CollClasse);
            Enchere.CollClasse.Clear();
            return res;
        }

        public static async Task<ObservableCollection<Offer>> GetLastSixOffer(int idEnchere)
        {
            var res = await _apiServices.GetAllAsyncID<Offer>("api/getLastSixOffer", Offer.CollClasse, "Id", idEnchere);
            Offer.CollClasse.Clear();
            return res;
        }

        public static async Task<int> PostEncherir(float montant, User user, Enchere enchere)
        {
            Encherir encherir = new Encherir(enchere.Id, montant, new DateTime(), enchere, user);
            return await _apiServices.PostAsync<Encherir>(encherir, "api/postEncherir");
        }

        public static async Task<int> PostEncherirInversee(float montant, User user, Enchere enchere)
        {
            Encherir encherir = new Encherir(enchere.Id, montant, new DateTime(), enchere, user);
            return await _apiServices.PostAsync<Encherir>(encherir, "api/postEncherirInversee");
        }
        #endregion
    }
}
