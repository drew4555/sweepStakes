using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    public interface ISweepstakesManager
    {
        //member variables

        //constructor
        void InsertSweepstakes(SweepStakes sweepstakes);

        SweepStakes GetSweepstakes();
 

        //member methods
    }
}
