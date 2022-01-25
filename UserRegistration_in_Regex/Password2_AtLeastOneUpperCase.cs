using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
	public class Password2_AtLeastOneUpperCase
	{
		public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; //Nitishkumar

		public bool ValidatePassword2(string password)
		{
			return Regex.IsMatch(password, REGEX_Password2);
		}
	}
}
