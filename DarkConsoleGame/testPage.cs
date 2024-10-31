using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	internal static class testPage
	{

		private static List<Character> Siniflar = new List<Character> {
				new Knight(80, 60, 70, 50),
				new Mage(900,50,70,50) ,
				new Knight(9000,50,70,40) };


		public static List<Character> getSiniflar()
		{
			return Siniflar;
		}

	}
}

