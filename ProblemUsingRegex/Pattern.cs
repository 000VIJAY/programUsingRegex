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
        public string validFirstName = @"^[A-Z][a-z]{3,10}";
        public string validLastName = @"^[A-Z][a-z]{3,10}";
        public bool ValidateFirstName(string firstName )
        {
            return Regex.IsMatch( firstName, validFirstName );
        }
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch( LastName, validLastName );
        }
    }
}