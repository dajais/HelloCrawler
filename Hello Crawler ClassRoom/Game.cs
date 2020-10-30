using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Game
	{
			

		public static string readInput() //Lee el input de la persona y lo devuelve en minuscula
		{
			string answer = Console.ReadLine().ToLower();
			return answer;
		}

		public static void display() //Te muestra la posicion en la que estas actualmente.
		{
			
			if (Player.hp != 0)
			{
				switch (Movement.position)
				{
					case 5:
					Console.WriteLine("UD ESTA EN POSICION 5" /*"\n You find yourself in a strange place, for some reason, you feel like you have been here before. I'm guessing you wanna get out, but why don't you take a look around first, maybe there is something that you can take with you... You see 4 doors which one do you want to open ? 'North door', 'South door', 'East door', West door'."*/);
					break;
					case 1:
					Console.WriteLine("UD ESTA EN POSICION 1" /*"\nWhen you enter de room, you see a shiny chest, being the greedy being that you are, you cannot let that pass. You open it and you find inside a couple of gold coins. Happy with the loot you got, you start paying attention to your surroundings. You see 2 doors. One that says 'East door' and another one that says 'South door', you have to decide where to go."*/);
					break;
					case 2:
					Console.WriteLine("UD ESTA EN POSICION 2" /*"\nYou open the door and you find yourself inside a dark, filthy and empty room, nothing to do here. So, you just decide to go. You se four doors, one says 'East door', another one says 'South door', another one says 'North door' and the last one says 'West door'. Which one do you take?"*/);
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
					Console.WriteLine("UD ESTA EN POSICION 7" /* FALTA AGREGAT TEXTO DESCRIPTIVO */);
					break;
					case 8:
					Console.WriteLine("UD ESTA EN POSICION 8" /*"\nThe instant you open the door you notice you have triggered a trap. An arrow comes flying directly to you. Luckyly, you are fast enough to dodge it (Nice one, by the way). You enter the room, carefully, afraid that the room may contain other traps. May I recommend you to leave? you see a door that says 'West door', other door that says 'North door' and one last door with a sign 'East door'. None of those appears to be triggers for more traps. So, which one is going to be?"*/);
					break;
					case 9:
					Console.WriteLine("UD ESTA EN POSICION 9" /*"\nYou enter to the room and, in a corner, you see a table. It appears to be full of food and drinks. It's a feast for sure. You pour yourself a well deserve glass of wine and you enjoy yourself for a momment. When you are siting there, you glance a shiny object, it's a gold glass, sitting there on the table. You take, because why not. With your stomach full and your new gold shiny object you are ready to leave the room. You see two doors. One says 'North door', the other one says 'West door'. Which one is gonna be?"*/);
					break;
					case 10:
					Console.WriteLine("UD ESTA EN POSICION 10" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 11:
					Console.WriteLine("UD ESTA EN POSICION 11" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 12:
					Console.WriteLine("UD ESTA EN POSICION 12" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 13:
					Console.WriteLine("UD ESTA EN POSICION 13" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 14:
					Console.WriteLine("UD ESTA EN POSICION 14" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 15:
					Console.WriteLine("UD ESTA EN POSICION 15" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 16:
					Console.WriteLine("UD ESTA EN POSICION 16" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 17:
					Console.WriteLine("UD ESTA EN POSICION 17" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 18:
					Console.WriteLine("UD ESTA EN POSICION 18" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 19:
					Console.WriteLine("UD ESTA EN POSICION 19" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 20:
					Console.WriteLine("UD ESTA EN POSICION 20" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 21:
					Console.WriteLine("UD ESTA EN POSICION 21" /* FALTA AGREGAR TEXTO DESCRIPTIVO */);
					break;
					case 22:
					Console.WriteLine("UD ESTA EN POSICION 22" /*"\nOh My God!... Is that... It cannot be... Yes! It is!!! Is the exit... Finally!!! You found the Exit... So now you have to decide if you feel that you have spent enough time here and you want to go, or if you want to take one of the doors and continue your jurney. The doors that you see are 'North door' and 'East door' and, of corse, the 'Exit'. What are you going to do?"*/);
					break;
					case 23:
					Console.WriteLine("UD ESTA EN POSICION 23 - SALIDA" /*"\nYou are finally free, you step out of the dungeon, with your loot and your memories. Good times huh? But, would you do it again?... Something to think about. For now, you just look behind and you are happy to be alive and outside. Congratulations free person, now, let's go and enjoy yourself"*/);
					break;
				}
			}
			else
			{
				Console.WriteLine("You are Dead");
			}
		}

		public static void display2() //Este es el set de habitaciones en caso de que ya haya estado ahi. 
		{
			switch (Movement.position)
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
				Console.WriteLine("UD YA ESTUVO EN POSICION 10");
				break;
				case 11:
				Console.WriteLine("UD YA ESTUVO EN POSICION 11");
				break;
				case 12:
				Console.WriteLine("UD YA ESTUVO EN POSICION 12");
				break;
				case 13:
				Console.WriteLine("UD YA ESTUVO EN POSICION 13");
				break;
				case 14:
				Console.WriteLine("UD YA ESTUVO EN POSICION 14");
				break;
				case 15:
				Console.WriteLine("UD YA ESTUVO EN POSICION 15");
				break;
				case 16:
				Console.WriteLine("UD YA ESTUVO EN POSICION 16");
				break;
				case 17:
				Console.WriteLine("UD YA ESTUVO EN POSICION 17");
				break;
				case 18:
				Console.WriteLine("UD YA ESTUVO EN POSICION 18");
				break;
				case 19:
				Console.WriteLine("UD YA ESTUVO EN POSICION 19");
				break;
				case 20:
				Console.WriteLine("UD YA ESTUVO EN POSICION 20");
				break;
				case 21:
				Console.WriteLine("UD YA ESTUVO EN POSICION 21");
				break;
				case 22:
				Console.WriteLine("UD YA ESTUVO EN POSICION 22");
				break;
			}
		}

		public static void ShowHelp()
		{
			Console.WriteLine("So you need help? What a noob... Ok... \n  Type 'Map' to see the rooms you've already been in\n  Type 'Show Hp' too see how close to death you are");
		}

	}

	
}
