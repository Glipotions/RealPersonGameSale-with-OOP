using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Abstract
{
	public interface IMemberService
	{
		void Save(Member member);
		void Delete(Member member);
		void Update(Member member);
	}
}
