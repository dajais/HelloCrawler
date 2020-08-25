using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Actions
	{
		
		public void DrinkPotion(Player player)
		{
			if (player.Inventory.Contains("Hp Potion"))
			{
				if (player.hp < 100)
				{
					if ((player.hp + 20) > 100)
					{
						player.hp = 100;
						player.Inventory.Remove("Hp Potion");
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {player.hp}");
					}
					else
					{
						player.hp = player.hp + 20;
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {player.hp}");
						player.Inventory.Remove("Hp Potion");
					}
				}
				else
				{
					Console.WriteLine("Sorry mate, you are full Hp, I cannot let you waiste a Potion");
				}
			}
			else
			{
				Console.WriteLine("You don't have any Hp Potion to drink");
			}
		}


		public void pickUp(string item, Player player) 
		{
			player.Inventory.Add(item);
			Console.WriteLine($"You just picked up: {item}");
		}

		public void ShowInventory(Player player)
		{
			Console.WriteLine("You open your backpack and see: ");
			if (player.Inventory.Count == 0)
			{
				{
					Console.WriteLine("An empty and sad void, full of hope tho =)");
					Console.WriteLine($"And the ammount of gold you have is: {player.gold}");
				}
			}
			else
			{
				foreach (string element in player.Inventory)
				{
					Console.WriteLine(element);
				}
				Console.WriteLine($"And the ammount of gold you have is: {player.gold}");
			}
		}

	}


	

}
