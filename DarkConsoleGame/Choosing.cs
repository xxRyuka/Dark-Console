using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	public class Choosing 
	{



		public static void CharacterChooice(Character oyuncu)
		{
			Console.WriteLine($" Oyuncu Adiniz :  ");
			oyuncu.Name = Console.ReadLine();



			Console.WriteLine($"Sinif Sec {oyuncu.Name}: \n Siniflar : Knight[1] , Mage[2] , Archer[3]");
			int secim = Console.Read();


			List<Character> Siniflar = new List<Character> {
				new Knight(80, 60, 70, 50),
				new Mage(900,50,70,50) ,
				new Knight(9000,50,70,40) };


			if (secim < Siniflar.Count() && secim >= 0)
			{
				oyuncu = Siniflar[secim];
				Console.WriteLine(oyuncu.Name);
				oyuncu.GetInfo();
			}


		}


	}
}
