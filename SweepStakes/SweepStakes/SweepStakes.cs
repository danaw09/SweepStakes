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

        Dictionary<string, string> animals = new Dictionary<string, string>();

        internal static void Push(object sweepstakes)
        {
            throw new NotImplementedException();
        }

        public List<Contestant> contestantList { get; private set; }

        public SweepStakes( string firstname)
        {
           
            firstName = firstname;
        }

       

        public void RegisterContestant(Contestant contestant)
        {

        }

        public void pickWinner(string firstname)
        {
            SweepStakes sweepstakes = new SweepStakes("Test SweepStakes");
            List<Contestant> expected = new List<Contestant>();
            List<Contestant> actual = sweepstakes.contestantList;

            //generates random number needed 
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
   
}
