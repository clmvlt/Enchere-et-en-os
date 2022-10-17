using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Services
{
    public class TimerEventArgs : EventArgs
    {
        public TimeSpan TempsRestant { get; set; }

    }

}