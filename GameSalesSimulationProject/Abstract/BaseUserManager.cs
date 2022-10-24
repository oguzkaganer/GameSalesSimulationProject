using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Save(User user)
        {
            Console.WriteLine("Saved " + user.FirstName + " " + user.LastName);
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Updated " + user.FirstName + " " + user.LastName);
        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Deleted " + user.FirstName + " " + user.LastName);
        }
    }
}
