using GameMembership.Abstract;
using MenrisReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership.Adapter
{
	class MernisServiceAdapter : IMemberCheckService
	{
		public bool CheckIfRealPerson(Member member)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
			return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalId), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
		}
	}
}
