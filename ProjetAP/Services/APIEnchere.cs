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
        public static async Task<ObservableCollection<Enchere>> GetEncheresEnCours()
        {
            var res = await _apiServices.GetAllAsync<Enchere>("api/getEncheresEnCours", Enchere.CollClasse);
            Enchere.CollClasse.Clear();
            return res;
        }

        public static async Task<ObservableCollection<Enchere>> GetEncheresFutures()
        {
            var res = await _apiServices.GetAllAsync<Enchere>("api/getEncheresFutures", Enchere.CollClasse);
            Enchere.CollClasse.Clear();
            return res;
        }
        #endregion
    }
}
