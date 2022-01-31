using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamler_Game
{
	public class gamler
	{
		public static void first()
		{
			int everyday = 100;
			int everygame = 1;
		}
		public static void second()
		{
			
			Random random = new Random();
			int ran = random.Next(0, 2);
			if (ran== 1)
			{
				Console.WriteLine("Win");
			}
			else
			{
				Console.WriteLine("Loss");
			}

		}
	}
}
