using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager: ISweepStakesManager
    {
        private object sweepstakes;
        public Stack<SweepStakes> sweepstakesStack;
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<SweepStakes>();
        }

        

       
        public SweepStakes GetNextSweepstakesWinner()
        {
            return sweepstakesStack.Pop();
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}
