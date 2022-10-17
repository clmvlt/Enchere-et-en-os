using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles
{
    public class SignInVueModele : BaseVueModele
    {
        private string _resEnr;
        public string ResEnr
        {
            get => _resEnr;
            set => SetProperty(ref _resEnr, value);
        }
    }
}
