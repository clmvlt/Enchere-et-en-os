using ProjetAP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Interfaces
{
    interface IDecompteTimer
    {
        void Start(TimeSpan CountdownTime);
        void Stop();

        event EventHandler<TimerEventArgs> TicTac;
        event EventHandler Complet;
        event EventHandler Avorte;
    }
}