using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class SweepstakesQueueManager: ISweepstakesManager
    {
        //member variables
        Queue<SweepStakes> sweepstakesqueue = new Queue<SweepStakes>();
        SweepStakes currentSweepstake;

        //constructor
        public SweepstakesQueueManager()
        {

        }

        //member methods
        public SweepStakes GetSweepstakes()
        {
            currentSweepstake = sweepstakesqueue.Dequeue();
            return currentSweepstake;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            sweepstakesqueue.Enqueue(sweepstakes);
        }
    }
}
