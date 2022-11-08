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
        private string _btnLoginText;
        private bool _isBtnLoginEnabled;
        private int _columnSize;
        #endregion

        #region Constructeurs

        public LoginVueModele()
        {
            ErreurMsg = string.Empty;
            BtnLoginText = "Se connecter";
            IsBtnLoginEnabled = true;
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

        public string BtnLoginText { get => _btnLoginText; set => SetProperty(ref _btnLoginText, value); }
        public bool IsErreurVisible { get => _isErreurVisible; set => SetProperty(ref _isErreurVisible, value); }
        public bool IsBtnLoginEnabled { get => _isBtnLoginEnabled; set => SetProperty(ref _isBtnLoginEnabled, value); }

        
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