using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    public class SweepStakes
    {
        //member variables
        Dictionary<int, Contestant> participants = new Dictionary<int, Contestant>();
        Contestant winner;
        string name;
        //constructor
        public SweepStakes(string name)
        {
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            participants.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            Random rand = new Random();
            List<int> keylist = new List<int>(participants.Keys);
            int randomkey = keylist[rand.Next(keylist.Count)];
            winner = participants[randomkey];
            return winner.firstName;   
        }
        public void PrintWinner(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> contest in participants)
            {
                if (contestant.firstName == winner.firstName)
                {
                    Console.WriteLine($"Contestant Id: {contestant.registrationNumber} First name: {contestant.firstName}" +
                        $"Last name: {contestant.lastName} Email address: {contestant.emailAddress} ");
                }
            }
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Please enter an contestants name: ");
            string value = Console.ReadLine();
            foreach(KeyValuePair<int, Contestant> contest in participants)
            {
                if(contestant.firstName == value)
                {
                    Console.WriteLine($"Contestant Id: {contestant.registrationNumber} First name: {contestant.firstName}" +
                        $"Last name: {contestant.lastName} Email address: {contestant.emailAddress} ");
                }
            }
        }
    }
}
