using ProjetAP.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Services
{
    public static class APIUser
    {

        #region Attributs
        private static readonly Api _apiServices = new Api();
        #endregion

        #region Constructeurs
        #endregion

        #region Getters/Setters
        #endregion

        #region Methodes
        public static async Task<User> GetUserWithMailAndPass(string mail, string pass)
        {
            return await _apiServices.GetOneAsync<User>("api/getUserByMailAndPass", new User(0, mail, pass, "", ""));
        }
        public static async Task<User> GetUserById(int id)
        {
            return await _apiServices.GetOneAsync<User>("api/getUser", new User(id, "", "", "", ""));
        }
        public static async Task<User> GetGagnantById(int id)
        {
            return await _apiServices.GetOneAsync<User>("api/getGagnant", new User(id, "", "", "", ""));
        }
        public static async Task<int> CreateUser(User user)
        {
            return await _apiServices.PostAsync<User>(user, "api/postUser");
        }
        #endregion
    }
}
