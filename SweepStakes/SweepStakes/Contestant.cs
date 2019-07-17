using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public string dob;
        public string postalCode;

       
        public Contestant(string _firstName, string _lastName, string _email, string _dob, string _postalCode = null)
        {
            firstName = _firstName;
            lastName = _lastName;
            email = _email;
            dob = _dob;
            postalCode = _postalCode;
        }
    }
}
