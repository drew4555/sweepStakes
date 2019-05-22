using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class MarketingFirm
    {
        //member variables
        ISweepstakesManager manager;
        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;   
        }

        //member methods
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
