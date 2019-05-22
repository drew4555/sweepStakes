using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class SweepstakesStackManager: ISweepstakesManager
    {
        //member variables
        SweepStakes currentSweepstakes;
        Stack<SweepStakes> sweepStakesStack = new Stack<SweepStakes>();
        //constructor
        public SweepstakesStackManager()
        {

        }

        //member methods
        public SweepStakes GetSweepstakes()
        {
            currentSweepstakes = sweepStakesStack.Pop();
            return currentSweepstakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            sweepStakesStack.Push(sweepstakes);
        }
    }
}
