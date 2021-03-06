using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Abstract
{
	public interface IGameService
	{
		void Add(Game game);
		void delete(Game game);

	}
}
