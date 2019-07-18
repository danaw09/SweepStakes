using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepStakesManager
    {
        public Queue<SweepStakes> sweepstakesQue;
      
        public SweepstakesQueueManager()
        {
            sweepstakesQue = new Queue<SweepStakes>();

        }

        public SweepStakes SweepStakesnextSweepstake { get; private set; }
        public SweepStakes nextSweepstake { get; private set; }

        public SweepStakes GetNextSweepstakesWinner()
        {
            SweepStakesnextSweepstake = sweepstakesQue.Dequeue();
            return nextSweepstake;
        }

        public void InsertSweepstakes(SweepStakes sweepstake)
        {
            sweepstakesQue.Enqueue(sweepstake);
        }
    }

    
}
