using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace HelloCrawler
{
	class Program
	{
		static void Main(string[] args)
		{
			//Creo las instancias de todas las clases para poder usarlas aca.
			Movement currentMovement = new Movement(); 
			Map currentMap = new Map();
			Game currentGame = new Game();
			Player currentPlayer = new Player();
			Combat currentCombat = new Combat();
			Actions currentActions = new Actions();

	
			currentMap.AddToTracking(5); //Hardcodeando el 5 que es la primer posicion de la lista para ver el mapa.
			currentGame.display(currentMovement, currentPlayer); //Arranca el juego (En la posicion 5). 

			while (currentMovement.position != 10 && currentPlayer.hp != 0) //Mientras no este en la casilla 10 y la vida sea mas de 0. 
			{
				string act = currentGame.readInput(); //Pido un input del jugador y se lo asigno a act. 
				switch (act)
				{
					case "north door":
					case "south door":
					case "west door":
					case "east door": //Si el input es una de estas 4 opciones, voy al if.
					if (currentMovement.ifChange(act)) //Aca podria ser == true y seria lo mismo. - ACA HUBO CAMBIO DE HABITACION
					{
						currentMovement.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
						if (currentMap.IfHere(currentMovement.position)) //Evaluo si ya estuvo o no en la habitacion esa.
						{
							currentGame.display(currentMovement, currentPlayer); // Muestro la nueva habitacion. 
						}
						else
						{
							currentGame.display2(currentMovement, currentPlayer); //Muestro la nueva habitacion pero con el texto de que ya estuvo ahi.
						}
						currentMap.AddToTracking(currentMovement.position); //Agrego la nueva habitacion al tracking de por donde pase.
					}
					break;
					case "fight":
					currentCombat.Fight(currentPlayer); //Entra en modo pelea 
					break;
					case "map":
					currentMap.ShowMap(); //Muestro el mapa (Que es la lista de habitaciones por las que pase) 
					break;
					case "help":
					currentGame.ShowHelp(); //Muestra los comandos
					break;
					case "show hp":
					currentPlayer.ShowHp(); //Muestra la vida
					break;
					case "drink potion":
					currentActions.DrinkPotion(currentPlayer); //Muestra la vida
					break;
					case "show inventory":
					currentActions.ShowInventory(currentPlayer); //Muestra la vida
					break;
					case "pick up":
					currentActions.pickUp("Hp Potion", currentPlayer);
					break;
					case "exit":
					if (currentMovement.ifChange(act))
					{
						currentMovement.action(act); //Hago el cambio de habitacion (llamando a Action en la class)
						currentGame.display(currentMovement, currentPlayer); // Muestro la nueva habitacion. 
					}
					break;
					default:
					Console.WriteLine("\nIs that what it says in the door ? ...Is it really ?... Try again"); // No era ninguna de las opciones, asi que no registro nada, no muestro nada, no aumento el i, no guardo el movimiento en el array, no hace nada. Solo te dice que esta mal y te manda a escribir de nuevo el input.
					break;
				}
			}
			if (currentPlayer.hp == 0)
			{
				Console.WriteLine("Sorry mate, you dead =( ");
			}
		}
	}
}
