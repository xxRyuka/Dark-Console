
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{

	// Knight : Sovalye
	internal class Knight : Character, ICharacter
	{
		 
		public Knight( int health, int strenght, int luck, int resist) : base( health, strenght, luck, resist)
		{
			this.ClassName = typeof(Knight).Name;
		}

		public override int Attack()
		{
			int specialCounter = RandomGenerator.rnd.Next(Luck, 100 + Convert.ToInt32(Luck * (0.4)));
			if (specialCounter > 90 && specialCounter < 120)
			{
				int randomAttack = RandomGenerator.rnd.Next(this.Luck, this.Luck + this.Strenght);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{this.Name} Kanasusadi, Kadim Şövalyenin Gazabi Yaklaşiyor !!! \n");
				Console.ForegroundColor = ConsoleSettings.currentColor;
				return (Convert.ToInt32((this.Strenght) * 0.9) + Convert.ToInt32((randomAttack) * 1.8));
			}
            else if (specialCounter >= 120)
            {
				int randomAttack = RandomGenerator.rnd.Next(this.Luck, this.Luck + this.Strenght);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{this.Name} Ölümle Dans Ediyor, Ortalık Kan Gölüne Dönecek  \n");
				Console.ForegroundColor =  ConsoleSettings.currentColor;
				return (Convert.ToInt32((this.Strenght) * 1.6) + Convert.ToInt32((randomAttack) * 2.2));
			}

            else
			{
				return base.Attack();
			}

		}

		public override int Defence()
		{
			int specialCounter = RandomGenerator.rnd.Next(Luck, 100 + Convert.ToInt32(Luck * (0.4)));
			if (specialCounter > 90 && specialCounter < 120)
			{
				int randomDefence = RandomGenerator.rnd.Next(this.Luck, this.Luck + this.Resist);
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine($"{this.Name} Savaş Naraları Atıyor  \n");
				Console.ForegroundColor =  ConsoleSettings.currentColor;
				return (Convert.ToInt32(this.Resist * 2)) + randomDefence;
			}


			else
			{
				return base.Defence();
			}
		}

		public override void DamageTaken(int damage)
		{
			 base.DamageTaken(damage);
		}

	}
}
