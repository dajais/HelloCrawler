using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Actions
	{
		
		public static void DrinkPotion()
		{
			if (Player.Inventory.Contains("Hp Potion"))
			{
				if (Player.hp < 100)
				{
					if ((Player.hp + 20) > 100)
					{
						Player.hp = 100;
						Player.Inventory.Remove("Hp Potion");
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {Player.hp}");
					}
					else
					{
						Player.hp = Player.hp + 20;
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {Player.hp}");
						Player.Inventory.Remove("Hp Potion");
					}
				}
				else
				{
					Console.WriteLine("Your Hp is full");
				}
			}
			else
			{
				Console.WriteLine("You don't have any Hp Potion to drink");
			}
		}


		public static void pickUp(string item) 
		{
			Player.Inventory.Add(item);
			Console.WriteLine($"You just picked up: {item}");
		}

		public static void ShowInventory()
		{
			Console.WriteLine("You open your backpack and see: ");
			if (Player.Inventory.Count == 0)
			{
				{
					Console.WriteLine("An empty and sad void, full of hope tho =)");
					Console.WriteLine($"And the ammount of gold you have is: {Player.gold}");
				}
			}
			else
			{
				foreach (string element in Player.Inventory)
				{
					Console.WriteLine(element);
				}
				Console.WriteLine($"And the ammount of gold you have is: {Player.gold}");
			}
		}

	}


	

}
