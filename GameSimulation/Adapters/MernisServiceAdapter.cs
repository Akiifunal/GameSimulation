using GameSimulation.Abstracts;
using GameSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Adapters
{
    
    
        public class MernisServiceAdapter : IGamerCheckService
        {
            public bool CheckIfRealPerson(Gamer gamer)
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient((KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12));
                Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.Id), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.UserNo.ToUpper());
                return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
            }
        }
    
}
