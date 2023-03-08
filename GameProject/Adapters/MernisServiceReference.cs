using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisServiceReference: IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt32(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.BirthDate.Year);
        }
    }
}
