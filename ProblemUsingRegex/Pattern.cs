using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProblemUsingRegex
{
    public class Pattern
    {
        public string validFirstName = @"^[A-Z][a-z]{3,10}$";
        public string validLastName = @"^[A-Z][a-z]{3,10}$";
        public string validEmailId = @"^[A-Za-z0-9._]+@[A-Za-z0-9]+.[a-z]{2,5}$";
        public bool ValidateFirstName(string firstName )
        {
            return Regex.IsMatch( firstName, validFirstName );
        }
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch( LastName, validLastName );
        }
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, validEmailId);
        }
    }
}