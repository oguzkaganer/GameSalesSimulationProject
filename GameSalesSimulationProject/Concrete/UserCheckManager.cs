using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
