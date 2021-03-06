using GameMembership.Abstract;
using GameMembership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Concrete
{
	class SaleManager : ISaleService
	{
		public void Add(Member member, Game game, Campaign campaign)
		{
			Console.WriteLine("Oyun Eklendi\nOyun : "+game.GameName+"\nKişi : "+member.FirstName+" "+ member.LastName+"\nKampanya : "+campaign.CampaignName);
		}

		public void Delete(Member member, Game game, Campaign campaign)
		{
			Console.WriteLine("Oyun Silindi\nOyun : " + game.GameName + "\nKişi : " + member.FirstName + " " + member.LastName + "\nKampanya : " + campaign.CampaignName);
		}

		public void Update(Member member, Game game, Campaign campaign)
		{
			Console.WriteLine("Oyun Güncellendi\nOyun : " + game.GameName + "\nKişi : " + member.FirstName + " " + member.LastName + "\nKampanya : " + campaign.CampaignName);
		}
	}
}
