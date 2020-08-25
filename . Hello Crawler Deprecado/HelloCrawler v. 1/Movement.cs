using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace HelloCrawler
{
	public class Movement
	{
		public int position; //Variable global que voy a usar todo el tiempo aca y en el main.
		public int hp;
		public int gold;
		public List<int> Tracking = new List<int>(); //Declaro lista para el Tracking de las habitaciones en las que estuvo.
		public List<string> Inventory = new List<string>();//Declaro lista para el inventario

		public Movement()
		{
			position = 5; //El juego empieza en la posicion 5
			hp = 100;
			gold = 0;
		}


		public void goNorth() //MOvimiento al norte.
		{
			switch (position)
			{
				case 4:
				position = 1;
				break;
				case 5:
				position = 2;
				Inventory.Add("Hp Potion");
				break;
				case 6:
				position = 3;
				hp = hp - 20;
				break;
				case 7:
				position = 4;
				break;
				case 8:
				position = 5;
				break;
				case 9:
				position = 6;
				break;
				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public void goSouth() //Movimiento al sur
		{
			switch (position)
			{
				case 1:
				position = 4;
				break;
				case 2:
				position = 5;
				break;
				case 3:
				position = 6;
				break;
				case 4:
				position = 7;
				break;
				case 5:
				position = 8;
				break;
				case 6:
				position = 9;
				break;
				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public void goEast() //Movimiento al este
		{
			switch (position)
			{
				case 1:
				position = 2;
				break;
				case 2:
				position = 3;
				break;
				case 4:
				position = 5;
				break;
				case 5:
				position = 6;
				break;
				case 7:
				position = 8;
				break;
				case 8:
				position = 9;
				break;
				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public void goWest() //Movimiento al oeste
		{
			switch (position)
			{
				case 2:
				position = 1;
				break;
				case 3:
				position = 2;
				break;
				case 5:
				position = 4;
				break;
				case 6:
				position = 5;
				break;
				case 8:
				position = 7;
				break;
				case 9:
				position = 8;
				break;
				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public bool IfHere (int room) //Analiza si ya estuvo en la habitacion y devuelve true or false
		{
			if(Tracking.Contains(room))
				{
					return false; //Si YA ESTUVO devuelve false(Para que despues en main lo agarre el else, que te lleva a Display2)
				}
			else
			{
				return true;
			}
		}

		public void exit() //Movimiento de salida
		{
			switch (position)
			{
				case 7:
				position = 10;
				break;
			}
		}

		public void AddToTracking(int room) //Agrega la habitacion al tracking por los que ya paso
		{
			Tracking.Add(room);
		}

		public void AddToInventory(string item)
		{
			Inventory.Add(item);
		}

		public void ShowMap() //Funcion que muestra el mapa
		{
			Console.Write("The rooms you already visited are: ");
			foreach (int element  in Tracking)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine("");
		}

		public void ShowInventory()
		{
			Console.WriteLine("You open your backpack and see: ");
			if (Inventory.Count == 0)
			{
				{
					Console.WriteLine("An empty and sad void, full of hope tho =)");
					Console.WriteLine($"And the ammount of gold you have is: {gold}");
				}
			}
			else
			{
				foreach (string element in Inventory)
				{
					Console.WriteLine(element);
				}
				Console.WriteLine($"And the ammount of gold you have is: {gold}");
			}
		}
		
		public void Combat()
		{
			hp = hp - 15;
			Console.WriteLine("You hit the enemy and you kill it, but not before he hits for 15 Hp");
		}
		
		public void ShowHelp()
		{
			Console.WriteLine("So you need help? What a noob... Ok... \n  Type 'Map' to see the rooms you've already been in\n  Type 'Show Hp' too see how close to death you are");
		}

		public void ShowHp()
		{
			Console.WriteLine($"Your current HP is: {hp}");
		}

		public void DrinkPotion()
		{
			if (Inventory.Contains("Hp Potion"))
			{
				if (hp < 100)
				{
					if ((hp + 20) > 100)
					{
						hp = 100;
						Inventory.Remove("Hp Potion");
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {hp}");
					}
					else
					{
						hp = hp + 20;
						Console.WriteLine($"Damn that was refreshing... Just in case you were wondering... Your current Hp is: {hp}");
						Inventory.Remove("Hp Potion");
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

		public string readInput() //Lee el input de la persona y lo devuelve en minuscula
		{
			string answer = Console.ReadLine().ToLower();
			return answer;
		}

		public bool ifChange(string act) //Evalua Si en la posicion en la que esta puede hacer la accion que quiere hacer. 
		{
			bool ifChange;
			switch (act)
			{
				case "north door":
				if (position == 4 || position == 5 || position == 6 || position == 7 || position == 8 || position == 9)
				{
					ifChange = true;
					return ifChange;
				}
				else
				{
					Console.WriteLine("That's not an option buddy");
					ifChange = false;
					return ifChange;
				}
				case "south door":
				if (position == 1 || position == 2 || position == 3 || position == 4 || position == 5 || position == 6)
				{
					ifChange = true;
					return ifChange;
				}
				else
				{
					Console.WriteLine("That's not an option buddy");
					ifChange = false;
					return ifChange;
				}
				case "east door":
				if (position == 1 || position == 2 || position == 4 || position == 5 || position == 7 || position == 8)
				{
					ifChange = true;
					return ifChange;
				}
				else
				{
					Console.WriteLine("That's not an option buddy");
					ifChange = false;
					return ifChange;
				}
				case "west door":
				if (position == 2 || position == 3 || position == 5 || position == 6 || position == 8 || position == 9)
				{
					ifChange = true;
					return ifChange;
				}
				else
				{
					Console.WriteLine("That's not an option buddy");
					ifChange = false;
					return ifChange;
				}
				case "exit":
				if (position == 7)
				{
					ifChange = true;
					return ifChange;
				}
				else
				{
					Console.WriteLine("That's not an option buddy");
					ifChange = false;
					return ifChange;
				}
				case "map":
				ifChange = true;
				return ifChange;
				default:
				Console.WriteLine("That's not an option buddy");
				ifChange = false;
				return ifChange;
			}
		}

		public void action(string act) //Toma la accion que la persona puso, evalua si se puede hacer, y si se puede, te manda a la funcion de accion que va.
		{
			switch (act)
			{
				case "north door":
					if (position == 4 || position == 5 || position == 6 || position == 7 || position == 8 || position == 9)
					{
					goNorth();
					}
					else
					{
					Console.WriteLine("That's not an option buddy");
					}
					break;
				case "south door":
					if (position == 1 || position == 2 || position == 3 || position == 4 || position == 5 || position == 6)
					{
					goSouth();
					}
					else
					{
					Console.WriteLine("That's not an option buddy");
					}
					break;
				case "east door":
					if (position == 1 || position == 2 || position == 4 || position == 5 || position == 7 || position == 8)
					{
					goEast();
					}
					else
					{
					Console.WriteLine("That's not an option buddy");
					}
					break;
				case "west door":
					if (position == 2 || position == 3 || position == 5 || position == 6 || position == 8 || position == 9)
					{
					goWest();
					}
					else
					{
					Console.WriteLine("That's not an option buddy");
					}
					break;
				case "exit":
					if (position == 7)
					{
					exit();
					}
					else
					{
					Console.WriteLine("That's not an option buddy");
					}
					break;
				case "map":
					{
					ShowMap();
					}
					break;
				default:
					{
					Console.WriteLine("Is that what it says in the door?... Is it really?");
					}
					break;
			}
		}
		
		public void display() //Te muestra la posicion en la que estas actualmente.
		{
			if (hp != 0)
			{
				switch (position)
				{
					case 5:
					Console.WriteLine("UD ESTA EN POSICION 5" /*"\n You find yourself in a strange place, for some reason, you feel like you have been here before. I'm guessing you wanna get out, but why don't you take a look around first, maybe there is something that you can take with you... You see 4 doors which one do you want to open ? 'North door', 'South door', 'East door', West door'."*/);
					break;
					case 1:
					Console.WriteLine("UD ESTA EN POSICION 1" /*"\nWhen you enter de room, you see a shiny chest, being the greedy being that you are, you cannot let that pass. You open it and you find inside a couple of gold coins. Happy with the loot you got, you start paying attention to your surroundings. You see 2 doors. One that says 'East door' and another one that says 'South door', you have to decide where to go."*/);
					break;
					case 2:
					Console.WriteLine("UD ESTA EN POSICION 2 Y ENCUENTRA UNA HP POTION" /*"\nYou open the door and you find yourself inside a dark, filthy and empty room, nothing to do here. So, you just decide to go. You se three doors, one says 'East door', another one says 'South door' and the last one says 'West door'. Which one do you take?"*/);
					break;
					case 3:
					Console.WriteLine("UD ESTA EN POSICION 3" /*"\nThe moment you enter the room you feel that something hits your head, then you hear someone laughing. You look up and you see an imp suddenly disapearing. That disgusting bastard just hit you and made himself invisible. He is still there, so you better run away. Which door will you take? the 'West door' or the 'South door'?"*/);
					break;
					case 4:
					Console.WriteLine("UD ESTA EN POSICION 4" /*"\nAn empty room, what a shame. It has doors tho, so at least you got that going on for you. Are you going to open the 'North door', the 'East door' or the 'South door'?"*/);
					break;
					case 6:
					Console.WriteLine("UD ESTA EN POSICION 6" /*"\nYou find yourself in an empty room, you start contemplating the emptiness of your own soul. So, let's leave that to the shrink, for now, you decide to get out of there. You see three doors: 'North door', 'West door' and 'South door'. Which one do you open?"*/);
					break;
					case 7:
					Console.WriteLine("UD ESTA EN POSICION 7" /*"\nOh My God!... Is that... It cannot be... Yes! It is!!! Is the exit... Finally!!! You found the Exit... So now you have to decide if you feel that you have spent enough time here and you want to go, or if you want to take one of the doors and continue your jurney. The doors that you see are 'North door' and 'East door' and, of corse, the 'Exit'. What are you going to do?"*/);
					break;
					case 8:
					Console.WriteLine("UD ESTA EN POSICION 8" /*"\nThe instant you open the door you notice you have triggered a trap. An arrow comes flying directly to you. Luckyly, you are fast enough to dodge it (Nice one, by the way). You enter the room, carefully, afraid that the room may contain other traps. May I recommend you to leave? you see a door that says 'West door', other door that says 'North door' and one last door with a sign 'East door'. None of those appears to be triggers for more traps. So, which one is going to be?"*/);
					break;
					case 9:
					Console.WriteLine("UD ESTA EN POSICION 9" /*"\nYou enter to the room and, in a corner, you see a table. It appears to be full of food and drinks. It's a feast for sure. You pour yourself a well deserve glass of wine and you enjoy yourself for a momment. When you are siting there, you glance a shiny object, it's a gold glass, sitting there on the table. You take, because why not. With your stomach full and your new gold shiny object you are ready to leave the room. You see two doors. One says 'North door', the other one says 'West door'. Which one is gonna be?"*/);
					break;
					case 10:
					Console.WriteLine("UD ESTA EN POSICION 10 SALIDA" /*"\nYou are finally free, you step out of the dungeon, with your loot and your memories. Good times huh? But, would you do it again?... Something to think about. For now, you just look behind and you are happy to be alive and outside. Congratulations free person, now, let's go and enjoy yourself"*/);
					break;
				}
			}
			else
			{
				Console.WriteLine("You are Dead");
			}
		}

		public void display2() //Este es el set de habitaciones en caso de que ya haya estado ahi. 
		{
			switch (position)
			{
				case 5:
				Console.WriteLine("UD YA ESTUVO EN POSICION 5");
				break;
				case 1:
				Console.WriteLine("UD YA ESTUVO EN POSICION 1");
				break;
				case 2:
				Console.WriteLine("UD YA ESTUVO EN POSICION 2");
				break;
				case 3:
				Console.WriteLine("UD YA ESTUVO EN POSICION 3");
				break;
				case 4:
				Console.WriteLine("UD YA ESTUVO EN POSICION 4");
				break;
				case 6:
				Console.WriteLine("UD YA ESTUVO EN POSICION 6");
				break;
				case 7:
				Console.WriteLine("UD YA ESTUVO EN POSICION 7");
				break;
				case 8:
				Console.WriteLine("UD YA ESTUVO EN POSICION 8");
				break;
				case 9:
				Console.WriteLine("UD YA ESTUVO EN POSICION 9");
				break;
				case 10:
				Console.WriteLine("UD YA ESTUVO EN POSICION 10 SALIDA");
				break;
			}
		}

	}
}
