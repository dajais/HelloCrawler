using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Combat
	{
		

		public static void Fight()
		{
			Player.hp = Player.hp - 15;
			Console.WriteLine("You hit the enemy and you kill it, but not before he hits for 15 Hp");
		}
	}


	
}
