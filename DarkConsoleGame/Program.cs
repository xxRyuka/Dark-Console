using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Clear();

			ConsoleSettings.Dark_Console();// Dark Console Yazisi
			Console.ForegroundColor = ConsoleColor.White;


			Game yeniOyun = new Game();
			Console.WriteLine("Oyuna Baslamak İçin (1) Oyun Hakkinda Bilgi Almak İçin (2)");
			int secim = Convert.ToInt32(Console.ReadLine());
			if (secim == 1)
			{
				yeniOyun.StartGame();

			}
			else if (secim == 2)
			{
				Console.WriteLine("\n 3 e basarak mevcut canları goruntuleyebilirsiniz\n" +
					"\n Her Raund Belirlenen Saldiri ve Savunma Puanları Statlarinila Dogru Orantili Olarak Değişkendir \n"+
					"\n Egerki O Raund İçin Geçerli Saldiri Puanınız Karşı Tarafin Savunma Puanından Yüksek İse Aradaki Fark Rakibin Canini Eksiltirsiniz	\n" +
					"\n Egerki O Raund İçin Geçerli Savunma Puanınız Karşı Tarafin Saldiri Puanından Yüksek İse Aradaki Fark Kadar Can Yenilersiniz\n");
                Console.WriteLine(" \n Karakterinizin Atagini Ve Defansinin puanini Şansi ve İlgili Statlari Belirlemektedir \n" +
					"\n Ayni Zamanda Şansi Özel Yeteneklerinin Gerçekleşme İhtimalinide Yükseltir  \n\n" +
					"\n Özel Yetenekler : Her Karakterin temel saldirisinin ve savunmasinin dişinda olan yüksek hasar ve defans özellikleri olan özel saldiri/savunma hamleleridir\n");
				Console.WriteLine("\n Karakter Statlari");
				Console.WriteLine(@"
			Knight: Health: 1150, Strength: 40, Luck: 60, Resist: 60 

			Mage: Health: 1000, Strength: 75, Luck: 65, Resist: 40

			Archer: Health: 900, Strength: 65, Luck: 70, Resist: 50

			Assassin: Health: 850, Strength: 50, Luck: 85, Resist: 35 "+"\n");
                Console.WriteLine("Hazirsaniz Oyuna Başlamak İçin Bir 'Tuşa' Basiniz");
				Console.ReadKey();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Clear();

				ConsoleSettings.Dark_Console();// Dark Console Yazisi
				Console.ForegroundColor = ConsoleColor.DarkYellow; yeniOyun.StartGame();
			}


			Console.ReadLine();


		}
	}


}
