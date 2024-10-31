using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
	internal interface ICharacter
	{
		void GetInfo();
		int Attack();
		int Defence();
		void DamageTaken(int damage);


	}
}
