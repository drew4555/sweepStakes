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
        void IntroToContestant()
        {
            string register;
            Console.WriteLine("Welcome to the sweepstakes! Would you like to register for the sweepstakes?");
            Console.WriteLine("Please choose ","yes"," or ","no" );
            register = Console.ReadLine().ToLower();
            Console.ReadKey();
            switch (register)
            {
                case "yes":
                    
                        RegisterContestant();
                        break;
                    
                case "no":
                    Console.WriteLine("Thank you for your participation");
                    break;
            }
        }
        void RegisterContestant()
        {
            Contestant contestant = new Contestant();
            Console.WriteLine("Please enter your first name");
            contestant.firstname = Console.ReadLine().ToString();
            Console.WriteLine("Please enter your last name");
            contestant.lastname = Console.ReadLine().ToString();
            Console.WriteLine("please enter your email address");
            contestant.email = Console.ReadLine().ToString();
            contestant.AssignRegistrationNumber();

        }
    }
}
