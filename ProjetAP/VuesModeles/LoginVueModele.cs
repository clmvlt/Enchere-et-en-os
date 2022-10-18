using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.Vues;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetAP.VuesModeles
{
    public class LoginVueModele : BaseVueModele
    {
        #region Attributs
        private string _erreurMsg;
        private bool _isErreurVisible;
        #endregion

        #region Constructeurs

        public LoginVueModele()
        {
            ErreurMsg = string.Empty;
        }

        #endregion

        #region Getters/Setters
        public string ErreurMsg
        {
            get => _erreurMsg;
            set => SetProperty(ref _erreurMsg, value);
        }

        public ICommand TapCommand
        {
            get => new Command(
                () =>
                {
                    App.Current.MainPage = new SingInVue();
                });
        }
        public bool IsErreurVisible { get => _isErreurVisible; set => SetProperty(ref _isErreurVisible, value); }
        #endregion

        #region Methodes
        public void SetErreurMsg(string err)
        {
            this.ErreurMsg = err;
            if (ErreurMsg == string.Empty)
            {
                this.IsErreurVisible = false;
            } else
            {
                this.IsErreurVisible = true;
            }
        }
        #endregion
    }
}