using GameMembership.Abstract;
using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Concrete
{
	public class GameManager : IGameService
	{

		public void delete(Game game)
		{
			Console.WriteLine(game.GameName + " Oyunu Silindi");
		}

		public void Add(Game game)
		{
			Console.WriteLine(game.GameName+" Oyunu satın alındı!");
		}
	}
}
