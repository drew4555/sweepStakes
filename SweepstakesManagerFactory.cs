using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class SweepstakesManagerFactory
    {
        //member variables

        //constructor
        public SweepstakesManagerFactory()
        {

        }

        //member methods
        public string ChooseWhichMethod()
        {
            string choice;
            Console.WriteLine("would you like use the sweepstakes in the stack or queue?");
            choice = Console.ReadLine().ToLower();
            return choice;
        }

    }
}
