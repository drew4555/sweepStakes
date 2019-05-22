using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class SweepstakesManagerFactory
    {
        public ISweepstakesManager GenerateSweepstakesManager(string choice)
        {
            switch (choice)
            {
                case "stack":
                    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                    return sweepstakesStackManager;

                case "queue":
                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    return sweepstakesQueueManager;

                default:
                    SweepstakesQueueManager sweepstakesQueueManager1 = new SweepstakesQueueManager();
                    return sweepstakesQueueManager1;

            }
        }
    }
}
