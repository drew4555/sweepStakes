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
            IntroToUser();
        }
        //member methods
        void IntroToUser()
        {
            
            string register;
            Console.WriteLine("Welcome to the sweepstakes! Are you a participant or manager?");
            Console.WriteLine("Please choose ","user"," or ","manager" );
            register = Console.ReadLine().ToLower();
            Console.ReadKey();
            switch (register)
            {
                case "participant":
                        Contestant contestant = new Contestant();
                        break;
                    
                case "manager":
                    ChooseWhichMethod();
                    break;
            }
        }
        public string ChooseWhichMethod()
        {
            string choice;
            Console.WriteLine("would you like use the sweepstakes in the stack or queue?");
            choice = Console.ReadLine().ToLower();
            return choice;

            
            
        }
    }
}
