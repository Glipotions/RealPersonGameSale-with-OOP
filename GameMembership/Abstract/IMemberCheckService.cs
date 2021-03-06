using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Abstract
{
	public interface IMemberCheckService
	{
		bool CheckIfRealPerson(Member member);
	}
}
