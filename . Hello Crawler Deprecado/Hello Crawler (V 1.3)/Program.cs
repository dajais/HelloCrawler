using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace HelloCrawler
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Map.AddToTracking(5); //Hardcodeando el 5 que es la primer posicion de la lista para ver el mapa.
			Game.display(); //Arranca el juego (En la posicion 5). 

			while (Movement.position != 23 && Player.hp != 0) //Mientras no este en la casilla 10 y la vida sea mas de 0. 
			{
				string act = Game.readInput(); //Pido un input del jugador y se lo asigno a act. 
				switch (act)
				{
					case "north door":
					case "south door":
					case "west door":
					case "east door": //Si el input es una de estas 4 opciones, voy al if.
					if (Movement.ifChange(act)) //Aca podria ser == true y seria lo mismo. - ACA HUBO CAMBIO DE HABITACION
					{
						Movement.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
						if (Map.IfHere(Movement.position)) //Evaluo si ya estuvo o no en la habitacion esa.
						{
							Game.display(); // Muestro la nueva habitacion. 
						}
						else
						{
							Game.display2(); //Muestro la nueva habitacion pero con el texto de que ya estuvo ahi.
						}
						Map.AddToTracking(Movement.position); //Agrego la nueva habitacion al tracking de por donde pase.
					}
					break;
					case "fight":
					Combat.Fight(); //Entra en modo pelea 
					break;
					case "map":
					Map.ShowMap(); //Muestro el mapa (Que es la lista de habitaciones por las que pase) 
					break;
					case "help":
					Game.ShowHelp(); //Muestra los comandos
					break;
					case "show hp":
					Player.ShowHp(); //Muestra la vida
					break;
					case "drink potion":
					Actions.DrinkPotion(); //Muestra la vida
					break;
					case "show inventory":
					Actions.ShowInventory(); //Muestra la vida
					break;
					case "pick up":
					Actions.pickUp("Hp Potion");
					break;
					case "exit":
					if (Movement.ifChange(act))
					{
						Movement.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
						Game.display(); // Muestro la nueva habitacion. 
					}
					break;
					default:
					Console.WriteLine("\nIs that what it says in the door ? ...Is it really ?... Try again"); // No era ninguna de las opciones, asi que no registro nada, no muestro nada, no aumento el i, no guardo el movimiento en el array, no hace nada. Solo te dice que esta mal y te manda a escribir de nuevo el input.
					break;
				}
			}
			if (Player.hp == 0)
			{
				Console.WriteLine("Sorry mate, you dead =( ");
			}
		}
	}
}
