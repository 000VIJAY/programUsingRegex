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
        public string validFirstName = @"^[A-Z]{1}";
        public bool ValidateFirstName(string firstName )
        {
            return Regex.IsMatch( firstName, validFirstName );
        }
    }
}