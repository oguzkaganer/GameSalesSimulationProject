using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Concrete
{
    public class UserManager : BaseUserManager
    {

        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Save(user);
            }
            else
            {
                Console.WriteLine("Bilgileriniz doğrulanamadı.");

            }
        }
    }
}
