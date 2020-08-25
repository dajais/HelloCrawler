using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace HelloCrawler
{
	class Program
	{
		static void Main(string[] args)
		{
			Movement currentPosition = new Movement(); //Creo una instancia de la Class Movement para usar aca. 
			currentPosition.AddToTracking(5); //Hardcodeando el 5 que es la primer posicion de la lista para ver el mapa.
			
			currentPosition.display(); //Arranca el juego (En la posicion 5). 

			while (currentPosition.position != 10 && currentPosition.hp != 0) //Mientras no este en la casilla 10 y la vida sea mas de 0. 
			{
				string act = currentPosition.readInput(); //Pido un input del jugador y se lo asigno a act. 
				switch (act)
				{
					case "north door":
					case "south door":
					case "west door":
					case "east door": //Si el input es una de estas 5 opciones, voy al if.
						if (currentPosition.ifChange(act)) //Aca podria ser == true y seria lo mismo. - ACA HUBO CAMBIO DE HABITACION
						{
						currentPosition.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
							if(currentPosition.IfHere(currentPosition.position)) //Evaluo si ya estuvo o no en la habitacion esa.
								{ 
								currentPosition.display(); // Muestro la nueva habitacion. 
								}
							else 
								{
							currentPosition.display2(); //Muestro la nueva habitacion pero con el texto de que ya estuvo ahi.
								}
						currentPosition.AddToTracking(currentPosition.position); //Agrego la nueva habitacion al tracking de por donde pase.
						}
						else
						{
						Console.WriteLine("Sorry mate, you are dead");
						}
					break;
					case "fight":
						currentPosition.Combat(); //Entra en modo pelea 
					break;
					case "map":
						currentPosition.ShowMap(); //Muestro el mapa (Que es la lista de habitaciones por las que pase) 
						break;
					case "help":
						currentPosition.ShowHelp(); //Muestra los comandos
					break;
					case "show hp":
						currentPosition.ShowHp(); //Muestra la vida
					break;
					case "drink potion":
						currentPosition.DrinkPotion(); //Muestra la vida
					break;
					case "show inventory":
						currentPosition.ShowInventory(); //Muestra la vida
					break;
					case "exit":
						if (currentPosition.ifChange(act))
						{
						currentPosition.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
						currentPosition.display(); // Muestro la nueva habitacion. 
						}
						break;
					default:
						Console.WriteLine("\nIs that what it says in the door ? ...Is it really ?... Try again"); // No era ninguna de las opciones, asi que no registro nada, no muestro nada, no aumento el i, no guardo el movimiento en el array, no hace nada. Solo te dice que esta mal y te manda a escribir de nuevo el input.
						break;
				}
			}
		}
	}
}
