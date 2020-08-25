using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Player
	{
		public int hp;
		public int gold;
		public List<string> Inventory = new List<string>();//Declaro lista para el inventario

		public Player()
		{
			hp = 100;
		}

		public void ShowHp()
		{
			Console.WriteLine($"Your current HP is: {hp}");
		}
	}
}
