using GameMembership.Abstract;
using GameMembership.Adapter;
using GameMembership.Concrete;
using GameMembership.Entities;
using System;
using System.Collections.Generic;

namespace GameMembership
{
	class Program
	{
		static void Main(string[] args)
		{
			MemberManager memberManager1 = new MemberManager(new MernisServiceAdapter());
			Member member1 = new Member 
			{
				FirstName = "Hamza",
				LastName = "Kavak",
				DateOfBirth = new DateTime(1998),
				Id = 1,
				NationalId = "123456789"
			};
			memberManager1.Save(member1);
			//List<IGameService> games = new List<IGameService>(GameManager1);
			GameManager gameManager1 = new GameManager();
			GameManager gameManager2 = new GameManager();
			Game game1 = new Game { Id = 1, GameName = "Call of Duty", GameType = "War" };
			Game game2 = new Game {Id = 2, GameName = "Need for Speed", GameType = "Race" };


			gameManager1.Add(game1);
			gameManager2.Add(game2);

			CampaignManager campaignManager = new CampaignManager();
			Campaign campaign = new Campaign{Id = 1, CampaignName = "Kış İndirimi", CampaignType = "%40 a varan indirimler." };
			campaignManager.Add(campaign);
			
			SaleManager saleManager1 = new SaleManager();
			saleManager1.Add(member1, game1, campaign);





		}
	}
}
