using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameSalesSimulationProject.Adapters
{
    internal class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            long identity = Convert.ToInt64(user.NationalityId);
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(identity, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateofBirth.Year);

            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;

            return sonuc;
        }
    }
}
