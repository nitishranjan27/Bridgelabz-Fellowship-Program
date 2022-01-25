using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
	public class Password1_Min8Char
	{
		public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //nitishkrRanjan, RanjanNitishKumar

		public bool ValidatePassword1(string password)
		{
			return Regex.IsMatch(password, REGEX_Password1);
		}
	}
}
