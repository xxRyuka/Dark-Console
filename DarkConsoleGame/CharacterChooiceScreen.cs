using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	internal static class CharacterChooiceScreen
	{

		public static int sira = 1;
		public static void CharacterChooice(ref Character oyuncu)
		{
			// İki Oyuncuda ayni sinifi secince  hata veriyordu hatayı şu şekilde çözdüm :
			// önceden listeyi yukarda tanımlamistim ve hep ayni objeleri kullanıyorlardı bunu fonksiyonun içine alarak ,
			// fonksiyon her cagirlidiğinda yeni objeler olusturmasini sagladim
			// Kodlar Karmasik hale gelmesin diye bunu ayri bir static sinif içine aldim

			List<Character> Siniflar = new List<Character> { // Character tipinden bir generic liste olusturduk ve sınıfları içinde tuttuk 
				new Knight(1150, 40, 60, 60),
				new Mage(1000,75,65,40) ,
				new Archer(900,65,70,50) ,
				new Assassin(850,50,85,35) };





			Console.WriteLine($"Player {sira} Adiniz :  ");
			string player1Name = Console.ReadLine();
			oyuncu.Name = player1Name;


			Console.WriteLine($"Sinif Sec {oyuncu.Name}: \n Siniflar : Knight[1] , Mage[2] , Archer[3] , Assassin[4] ");
			int secim = Convert.ToInt32(Console.ReadLine());


			bool isValidChooice = false;
			while (!isValidChooice)
			{


				if (secim <= Siniflar.Count() && secim >= 0)
				{

					oyuncu = Siniflar[secim - 1];
					oyuncu.Name = player1Name;
					Console.WriteLine(oyuncu.Name + " " + oyuncu.ClassName);
					oyuncu.GetInfo();
					isValidChooice = true;
				}
				else
				{
					Console.WriteLine($"Sinif Sec {oyuncu.Name}: \n Siniflar : Knight[1] , Mage[2] , Archer[3]");
					secim = Convert.ToInt32(Console.ReadLine());

				}
			}

			sira++;
		}

	}
}
