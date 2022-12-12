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
        public static async void Login(User user)
        {
            _user = user;
            await App.Current.MainPage.TranslateTo(App.Current.MainPage.Width, 0, 600);
            App.Current.MainPage = new AccueilVue();
        }
        public static async void Logout()
        {
            _user = null;
            await App.Current.MainPage.TranslateTo(-App.Current.MainPage.Width, 0, 600);
            App.Current.MainPage = new LoginVue();
        }

        public static bool IsVisiter()
        {
            return User.Id == -1;
        }

    }
}
