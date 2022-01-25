using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    public class LastName
    {
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }
    }
}
