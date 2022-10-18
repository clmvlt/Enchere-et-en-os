using ProjetAP.Modeles;
using ProjetAP.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Services
{
    public static class Session
    {
        private static User _user;
        
        public static User User
        {
            get => _user;
        }

        public static bool IsLogged() => _user != null;
        public static void Login(User user)
        {
            _user = user;
            App.Current.MainPage = new AccueilVue();
        }
        public static void Logout()
        {
            _user = null;
            App.Current.MainPage = new LoginVue();
        }

    }
}
