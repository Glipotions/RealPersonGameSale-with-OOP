using GameMembership.Abstract;
using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Concrete
{
	public class CampaignManager : ICampaignService
	{
		public void Add(Campaign campaign)
		{
			Console.WriteLine("Kampanya Eklendi: ");
		}

		public void Delete(Campaign campaign)
		{
			Console.WriteLine("Kampanya Silindi: ");
		}

		public void update(Campaign campaign)
		{
			Console.WriteLine("Kampanya Güncellendi: ");
		}
	}
}
