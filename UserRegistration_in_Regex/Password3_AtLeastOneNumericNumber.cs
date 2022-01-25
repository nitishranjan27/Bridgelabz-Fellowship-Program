using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
	public class Password3_AtLeastOneNumericNumber
	{
		public static string REGEX_Password3 = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$";  //Nitishkumar12

		public bool ValidatePassword3(string password)
		{
			return Regex.IsMatch(password, REGEX_Password3);
		}
	}
}
