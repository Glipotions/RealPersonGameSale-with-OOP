using GameMembership.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Concrete
{
	public class MemberCheckManager : IMemberCheckService
	{
		public bool CheckIfRealPerson(Member member)
		{
			return true;
		}
	}
}
