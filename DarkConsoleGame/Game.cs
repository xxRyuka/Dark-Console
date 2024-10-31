using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	internal class Game
	{
		Character oyuncu1;
		Character oyuncu2;
		private int round;



		public Game()
		{
			this.oyuncu1 = new Knight(1, 1, 1, 1);
			this.oyuncu2 = new Knight(1, 1, 1, 1);
		}

		public int ActionResult(Character oyuncu)
		{
			bool isValidAction = false;
			int x = 0;
			while (!isValidAction)
			{

				Console.WriteLine($"{oyuncu.Name} Saldırı(1) mi Savunma(2) mi");
				string oyuncuAction = Console.ReadLine();


				bool actionParse = int.TryParse(oyuncuAction, out x);



				if (actionParse && (x == 1 || x == 2))
				{
					isValidAction = true;
				}
				else if (x == 3)
				{
					oyuncu1.GetInfo();
					oyuncu2.GetInfo();
				}
				else
				{
					Console.WriteLine("Gecerli deger gir (1-2) ");
				}

			}

			return x;
		}

		public void StartGame()
		{
			CharacterChooiceScreen.CharacterChooice(ref this.oyuncu1);
			Console.WriteLine("\n");
			CharacterChooiceScreen.CharacterChooice(ref this.oyuncu2);


			while (oyuncu1.Health > 0 && oyuncu2.Health > 0)
			{

				int oyuncu1Action = ActionResult(oyuncu1);


				int oyuncu2Action = ActionResult(oyuncu2);
				Console.WriteLine("\n");


				RoundResult(oyuncu1Action, oyuncu2Action);

				Console.WriteLine($"\nRound {round + 1} Bitti \n");
				Console.WriteLine("------------------------- \n");
				round++;



				if (oyuncu1.currentHP() < 0)
				{

					Console.WriteLine("--------   OYUN BİTTİ   -------- \n");


					Console.ForegroundColor = ConsoleColor.Red;
					Thread.Sleep(1000);
					Console.WriteLine(@" 
                      .:::!~!!!!!:.
                  .xUHWH!! !!?M88WHX:.
                .X*#M@$!!  !X!M$$$$$$WWx:.
               :!!!!!!?H! :!$!$$$$$$$$$$8X:
              !!~  ~:~!! :~!$!#$$$$$$$$$$8X:
             :!~::!H!<   ~.U$X!?R$$$$$$$$MM!
             ~!~!!!!~~ .:XW$$$U!!?$$$$$$RMM!
               !:~~~ .:!M""T#$$$$WX??#MRRMMM!
               ~?WuxiW*`   `""#$$$$8!!!!??!!!
             :X- M$$$$       `""T#$T~!8$WUXU~
            :%`  ~#$$$m:        ~!~ ?$$$$$$
          :!`.-   ~T$$$$8xx.  .xWW- ~""""##*""
.....   -~~:<` !    ~?T#$$@@W@*?$$      /`
W$@@M!!! .!~~ !!     .:XUW$W!~ `""~:    :
#""~~`.:x%`!!  !H:   !WM$$$$Ti.: .!WUn+!`
:::~:!!`:X~ .: ?H.!u ""$$$B$$$!W:U!T$$M~
.~~   :X@!.-~   ?@WTWo(""*$$$W$TH$! `
Wi.~!X$?!-~    : ?$$$B$Wu(""**$RM!
$R@i.~~ !     :   ~$$$$$B$$en:``
?MXT@Wx.~    :     ~""##*$$$$M~

");

					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(oyuncu2.Name + " Kazandi");
					Console.WriteLine(oyuncu1.Name + " Ucurumdan Yuvarlandı");
				}
				else if (oyuncu2.currentHP() < 0)
				{
					Console.WriteLine("--------   OYUN BİTTİ   -------- \n");


					Console.ForegroundColor = ConsoleColor.Red;
					Thread.Sleep(1000);
					Console.WriteLine(@" 
                      .:::!~!!!!!:.
                  .xUHWH!! !!?M88WHX:.
                .X*#M@$!!  !X!M$$$$$$WWx:.
               :!!!!!!?H! :!$!$$$$$$$$$$8X:
              !!~  ~:~!! :~!$!#$$$$$$$$$$8X:
             :!~::!H!<   ~.U$X!?R$$$$$$$$MM!
             ~!~!!!!~~ .:XW$$$U!!?$$$$$$RMM!
               !:~~~ .:!M""T#$$$$WX??#MRRMMM!
               ~?WuxiW*`   `""#$$$$8!!!!??!!!
             :X- M$$$$       `""T#$T~!8$WUXU~
            :%`  ~#$$$m:        ~!~ ?$$$$$$
          :!`.-   ~T$$$$8xx.  .xWW- ~""""##*""
.....   -~~:<` !    ~?T#$$@@W@*?$$      /`
W$@@M!!! .!~~ !!     .:XUW$W!~ `""~:    :
#""~~`.:x%`!!  !H:   !WM$$$$Ti.: .!WUn+!`
:::~:!!`:X~ .: ?H.!u ""$$$B$$$!W:U!T$$M~
.~~   :X@!.-~   ?@WTWo(""*$$$W$TH$! `
Wi.~!X$?!-~    : ?$$$B$Wu(""**$RM!
$R@i.~~ !     :   ~$$$$$B$$en:``
?MXT@Wx.~    :     ~""##*$$$$M~

");

					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(oyuncu1.Name + " Kazandi");
					Console.WriteLine(oyuncu2.Name + " Ucurumdan Yuvarlandı");

				}
			}


		}

		public void CurrentInfo()
		{
			oyuncu1.GetInfo();
			oyuncu2.GetInfo();
		}

		public void RoundResult(int oyuncu1Action, int oyuncu2Action)
		{
			int oyuncu1Hasar;
			int oyuncu2Hasar;
			int oyuncu1Savuma;
			int oyuncu2Savuma;
			// ikiside Saldiri Secerse 

			Thread.Sleep(1000);

			if (oyuncu1Action == 1 && oyuncu2Action == 1) // İki Oyuncuda Saldiriyor
			{
				oyuncu1Hasar = oyuncu1.Attack();
				oyuncu2Hasar = oyuncu2.Attack();



				Console.WriteLine((oyuncu1.Name + " Saldiriyor "));
				Thread.Sleep(400);
				Console.WriteLine(oyuncu2.Name + " Saldiriyor \n");
				Thread.Sleep(400);

				Console.WriteLine($"{oyuncu1.Name} Saldiri Puani {oyuncu1Hasar}");
				Console.WriteLine($"{oyuncu2.Name} Saldiri Puani {oyuncu2Hasar} \n");

				oyuncu1.DamageTakenConsole(oyuncu2Hasar);
				oyuncu2.DamageTakenConsole(oyuncu1Hasar);
				Console.WriteLine("\n");
				CurrentInfo();

			}

			// oyuncu1 Saldiri oyuncu2 Savunma
			else if (oyuncu1Action == 1 && oyuncu2Action == 2)
			{
				oyuncu1Hasar = oyuncu1.Attack();
				oyuncu2Savuma = oyuncu2.Defence();

				Console.WriteLine((oyuncu1.Name + " Saldiriyor "));
				Thread.Sleep(400);
				Console.WriteLine(oyuncu2.Name + " Savunuyor \n");
				Thread.Sleep(400);


				Console.WriteLine($"{oyuncu1.Name} Saldiri Puani {oyuncu1Hasar}");
				Console.WriteLine($"{oyuncu2.Name} Savunma Puani {oyuncu2Savuma} \n");



				oyuncu2.DamageTaken((oyuncu1Hasar - oyuncu2Savuma));


				CurrentInfo();
			}


			// oyuncu 2 saldiriyor oyuncu1 savunuyor
			else if (oyuncu1Action == 2 && oyuncu2Action == 1)
			{
				oyuncu2Hasar = oyuncu2.Attack();
				oyuncu1Savuma = oyuncu1.Defence();



				Console.WriteLine(oyuncu1.Name + " Savunuyor ");
				Thread.Sleep(400);
				Console.WriteLine((oyuncu2.Name + " Saldiriyor \n"));
				Thread.Sleep(400);


				Console.WriteLine($"{oyuncu1.Name} Savunma Puani {oyuncu1Savuma}");
				Console.WriteLine($"{oyuncu2.Name} Saldiri Puani {oyuncu2Hasar}\n");

				oyuncu1.DamageTaken((oyuncu2Hasar - oyuncu1Savuma));


				CurrentInfo();
			}

			// her ikiisde savunma yapiyor
			else if (oyuncu1Action == 2 && oyuncu2Action == 2)
			{
				Console.WriteLine("İki Oyuncuda Savunma Yapti Korkaklar Sizi");
			}

			Console.ForegroundColor = ConsoleSettings.SetConsoleColor();

		}
	}
}
