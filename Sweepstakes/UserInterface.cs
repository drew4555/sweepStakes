using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class UserInterface
    {
        //member variables

        //costructor
        public UserInterface()
        {
            IntroToContestant();
        }
        //member methods
        static void IntroToContestant()
        {
            string register;
            Console.WriteLine("Welcome to the sweepstakes! Would you like to register for the sweepstakes?");
            Console.WriteLine("Please choose ","yes"," or ","no" );
            register = Console.ReadLine().ToLower();
            Console.ReadKey();
            switch (register)
            {
                case "yes":
                    
                        Contestant contestant = new Contestant();
                        break;
                    
                case "no":
                    Console.WriteLine("Thank you for your participation");
                    break;
            }
        }
    }
}
