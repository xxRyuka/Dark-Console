using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	public abstract class Character : ICharacter
	{
		public string ClassName;
		public string Name { get; set; }
        public int Health { get; set; } // Can
		public int Strenght { get; set; } // Güç
		public int Luck { get; set; } // Şans
		public int Resist { get; set; } // Direnç

        public Character(int health, int strenght,int luck,int resist)
        {
 
            Health = health;
            Strenght = strenght;
            Luck = luck;
            Resist = resist;            
        }

		public virtual void GetInfo()
		{
            Console.WriteLine($"{this.Name} Mevcut can: {Health}");
		}


		public virtual int Attack()
		{
			
			int randomAttack = RandomGenerator.rnd.Next(this.Luck, this.Luck + this.Strenght);
			return (Convert.ToInt32((this.Strenght)*0.4) + randomAttack  );
		}


		public virtual int Defence()
		{
			int randomDefence = RandomGenerator.rnd.Next(this.Luck , this.Luck + this.Resist);
			return (Convert.ToInt32(this.Resist * 0.4)) + randomDefence;


		}
		public virtual void DamageTaken(int damage)
		{
			Health -= damage;
		}

		public int currentHP()
		{ return Health; }

		public virtual int DamageTakenConsole(int _damageTaken)
		{
			this.Health -= _damageTaken;
			Console.WriteLine(this.Name + " hasar aldı : " + _damageTaken + " mevcut can : " + this.currentHP());
			return Health;
		}

		
	}
}
