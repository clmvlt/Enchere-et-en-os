using ProjetAP.Modeles;
using ProjetAP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles
{
    public class AccueilVueModele : BaseVueModele
    {
        #region Attribus
        private User _user;
        #endregion

        #region Constructeur
        #endregion

        #region Guetters Setteurs
        public User User { get => _user; set => SetProperty(ref _user, value); }
        public bool IsUserLogged
        {
            get => !Session.IsVisiter();
        }
        #endregion

        #region Methodes
        #endregion
    }
}
