using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrawler
{
	class Rooms
	{
		private int _potion = 1;


		public void inRoom2()
		{

			Movement.position = 2;
			_potion = 1;
			Console.WriteLine("There is a potion, 'pick up' to... you know... pick it up... ");
			string input = Console.ReadLine().ToLower();

			if(input == "levantar")
			{
				if (_potion != 0)
				{
					Player.Inventory.Add("Hp Potion");
					_potion = 0;
				}
				else
					Console.WriteLine("There is nothing to pick up here");
			}

		}



	}
}
