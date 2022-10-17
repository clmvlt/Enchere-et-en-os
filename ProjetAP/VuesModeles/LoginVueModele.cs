using ProjetAP.Modeles;
using ProjetAP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles
{
    public class LoginVueModele : BaseVueModele
    {
        #region Attributs
        private string _erreurMsg;
        #endregion

        #region Constructeurs

        public LoginVueModele()
        {
        }

        #endregion

        #region Getters/Setters
        public string ErreurMsg
        {
            get => _erreurMsg;
            set => SetProperty(ref _erreurMsg, value);
        }
        #endregion

        #region Methodes
        #endregion
    }
}