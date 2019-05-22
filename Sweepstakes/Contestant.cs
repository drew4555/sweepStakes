using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    public class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber = 0;
        

        //constructor
        public Contestant()
        {
            AssignInfo();
            AssignRegistrationNumber();
        }

        //member methods
        public void AssignRegistrationNumber()
        { 
             registrationNumber = registrationNumber++;
        }
        public void AssignInfo()
        {
            Contestant contestant = new Contestant();
            Console.WriteLine("Please enter your first name");
            contestant.firstName = Console.ReadLine().ToString();
            Console.WriteLine("Please enter your last name");
            contestant.lastName = Console.ReadLine().ToString();
            Console.WriteLine("please enter your email address");
            contestant.emailAddress = Console.ReadLine().ToString();
            contestant.AssignRegistrationNumber();
        }
    }
}
