using GameMembership.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Concrete
{
	public class MemberManager : IMemberService
	{
		private IMemberCheckService memberCheckService;

		public MemberManager(IMemberCheckService memberCheckService)
		{
			this.memberCheckService = memberCheckService;
		}

		public void Delete(Member member)
		{
			Console.WriteLine("Kişi Silindi");
		}

		public void Save(Member member)
		{
			if (memberCheckService.CheckIfRealPerson(member))
			{
				Console.WriteLine("Kişi Eklendi");
			}
			else
			{
				Console.WriteLine("Kişi Bilgileri yanlış");
			}
		}

		public void Update(Member member)
		{
			Console.WriteLine("Kişi Güncellendi");
		}
	}
}
