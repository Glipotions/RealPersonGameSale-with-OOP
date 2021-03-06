using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Abstract
{
	interface ISaleService
	{
		void Add(Member member, Game game, Campaign campaign);
		void Delete(Member member, Game game, Campaign campaign);
		void Update(Member member, Game game, Campaign campaign);


	}
}
