using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	public class Map
	{
		public List<int> Tracking = new List<int>(); //Declaro lista para el Tracking de las habitaciones en las que estuvo.

				
		
		public void AddToTracking(int room) //Agrega la habitacion al tracking por los que ya paso
		{
			Tracking.Add(room);
		}



		public void ShowMap() //Funcion que muestra el mapa
		{
			Console.Write("The rooms you already visited are: ");
			foreach (int element in Tracking)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine("");
		}

		public bool IfHere(int room) //Analiza si ya estuvo en la habitacion y devuelve true or false
		{
			if (Tracking.Contains(room))
			{
				return false; //Si YA ESTUVO devuelve false(Para que despues en main lo agarre el else, que te lleva a Display2)
			}
			else
			{
				return true;
			}
		}

	}


}
