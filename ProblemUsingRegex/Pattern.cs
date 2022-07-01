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
        public string validMobileNumber = @"^[1-9]{1,3} +[6-9]{1}[0-9]{9}";
        public string validPassword = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8}$";
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
        public bool ValidateMobileNumber(string moblieNumber)
        {
            return Regex.IsMatch( moblieNumber, validMobileNumber);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, validPassword);
        }
    }
}