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
		public static int position; //Variable global que voy a usar todo el tiempo aca y en el main.
			

		static Movement()
		{
			position = 5; //El juego empieza en la posicion 5
		}

		public static void goNorth() //MOvimiento al norte.
		{
			switch (position)
			{
				case 2:
				position = 10;
				break;
				case 4:
				position = 1;
				break;
				case 5:
				position = 2;
				break;
				case 6:
				position = 3;
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
				case 10:
				position = 11;
				break;
				case 12:
				position = 13;
				break;
				case 16:
				position = 15;
				break;
				case 17:
				position = 19;
				break;
				case 19:
				position = 20;
				break;
				case 20:
				position = 21;
				break;




				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public static void goSouth() //Movimiento al sur
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
				case 10:
				position = 2;
				break;
				case 11:
				position = 10;
				break;
				case 13:
				position = 12;
				break;
				case 15:
				position = 16;
				break;
				case 19:
				position = 17;
				break;
				case 20:
				position = 19;
				break;
				case 21:
				position = 20;
				break;




				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public static void goEast() //Movimiento al este
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
				case 11:
				position = 12;
				break;
				case 12:
				position = 14;
				break;
				case 14:
				position = 15;
				break;
				case 15:
				position = 14;
				break;
				case 17:
				position = 11;
				break;
				case 18:
				position = 17;
				break;
				case 21:
				position = 22;
				break;



				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public static void goWest() //Movimiento al oeste
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
				case 11:
				position = 17;
				break;
				case 12:
				position = 11;
				break;
				case 14:
				position = 12;
				break;
				case 15:
				position = 14;
				break;
				case 17:
				position = 18;
				break;
				case 22:
				position = 21;
				break;


				default:
				Console.WriteLine("That's not an option buddy");
				break;
			}
		}

		public static void exit() //Movimiento de salida
		{
			if (position == 22)
			{ 
				position = 23;
			}
		}


		public static bool ifChange(string act) //Evalua Si en la posicion en la que esta puede hacer la accion que quiere hacer. 
		{
			bool ifChange;
			switch (act)
			{
				case "north door":
					if (position == 2 || position == 4 || position == 5 || position == 6 || position == 7 || position == 8 || position == 9 || position == 10 || position == 12 || position == 16 || position == 17 || position == 19 || position == 20)
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
					if (position == 1 || position == 2 || position == 3 || position == 4 || position == 5 || position == 6 || position == 10 || position == 11 || position == 13 || position == 15 || position == 19 || position == 20 || position == 21)
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
					if (position == 1 || position == 2 || position == 4 || position == 5 || position == 7 || position == 8 || position == 11 || position == 12 || position == 14 || position == 17 || position == 18 || position == 21)
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
					if (position == 2 || position == 3 || position == 5 || position == 6 || position == 8 || position == 9 || position == 11 || position == 12 || position == 14 || position == 15 || position == 17 || position == 22)
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
					if (position == 22)
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

		public static void action(string act) //Toma la accion que la persona puso, evalua si se puede hacer, y si se puede, te manda a la funcion de accion que va.
		{
			switch (act)
			{
				case "north door":
					if (position == 2 || position == 4 || position == 5 || position == 6 || position == 7 || position == 8 || position == 9 || position == 10 || position == 12 || position == 16 || position == 17 || position == 19 || position == 20)
					{
						goNorth();
					}
					else
					{
						Console.WriteLine("That's not an option buddy");
					}
					break;
				case "south door":
					if (position == 1 || position == 2 || position == 3 || position == 4 || position == 5 || position == 6 || position == 10 || position == 11 || position == 13 || position == 15 || position == 19 || position == 20 || position == 21)
					{
						goSouth();
					}
					else
					{
						Console.WriteLine("That's not an option buddy");
					}
					break;
				case "east door":
					if (position == 1 || position == 2 || position == 4 || position == 5 || position == 7 || position == 8 || position == 11 || position == 12 || position == 14 || position == 17 || position == 18 || position == 21)
					{
						goEast();
					}
					else
					{
						Console.WriteLine("That's not an option buddy");
					}
					break;
				case "west door":
					if (position == 2 || position == 3 || position == 5 || position == 6 || position == 8 || position == 9 || position == 11 || position == 12 || position == 14 || position ==  15 || position == 17 || position == 22)
					{
						goWest();
					}
					else
					{
						Console.WriteLine("That's not an option buddy");
					}
					break;
				case "exit":
					if (position == 22)
					{
						exit();
					}
					else
					{
						Console.WriteLine("That's not an option buddy");
					}
					break;
				default:
					{
						Console.WriteLine("Is that what it says in the door?... Is it really?");
					}
					break;
			}
		}
		
		

	}
}
