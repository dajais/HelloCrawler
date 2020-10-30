using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Player
	{
		public static int hp;
		public static int gold;
		public static List<string> Inventory = new List<string>();//Declaro lista para el inventario


		static Player()
		{
			hp = 100;
		}

		public static void ShowHp()
		{
			Console.WriteLine($"Your current HP is: {hp}");
		}
	}
}
