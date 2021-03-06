using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Abstract
{
	public interface ICampaignService
	{
		void Add(Campaign campaign);
		void Delete(Campaign campaign);
		void update(Campaign campaign);

	}
}
