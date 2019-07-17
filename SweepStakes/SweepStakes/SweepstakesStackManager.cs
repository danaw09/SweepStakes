using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager: SweepstakesManager_interface
    {
        private object sweepstakes;

        public void PushOnToStack()
        {
            SweepStakes.Push(sweepstakes);
        }
    }
}
