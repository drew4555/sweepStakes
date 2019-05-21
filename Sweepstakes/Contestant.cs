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
        string firstname;
        string lastname;
        string email;
        double registrationNumber = 0;
        

        //constructor
        public Contestant()
        {

        }

        //member methods
        public void AssignRegistrationNumber()
        { 
             registrationNumber = registrationNumber++;
        }
    }
}
