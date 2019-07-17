using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
        public string firstName;
        public string Contestant;
        Random randomNumber = new Random ();
        private List<Contestant> contestants= new List<Contestant>();


        public void DisplayContestantName()
        {
            Dictionary<int, string> contestant = new Dictionary<int, string>();
            contestant.Add(1, "firstname");
            contestant.Add(2, "firstname");
        }





        public SweepStakes( string firstname)
        {
           
            firstName = firstname;
           
        }


        
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant);

        }


     

        public void pickWinner(string firstname)
        {
            int winner = randomNumber.Next(0, Contestant.Count() );
        } 

        public void PrintContestantInfo(Contestant contestant)
        {
            Contestant = String.Format("Firstname: [0], Lastname: [1], Email:[2], Registration:[3])"); 
        }


        internal static void Push(object sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
   
}
