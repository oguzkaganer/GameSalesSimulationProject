using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(User user, List<Game> games, Offer offer)
        {
            foreach (Game game in games)
            {
                Console.WriteLine(game.Name);
            }

            Console.WriteLine("oyunları " + offer.Name + " ile %" 
                + offer.discountRate + " indirim uygulanarak " + user.FirstName + " " 
                + user.LastName + " kullanıcısına satıldı.");
        }

        public void Sale(User user, Game game)
        {
            Console.WriteLine(game.Name + " oyunu " + user.FirstName + " " + user.LastName + " kullanıcısına satıldı." );
        }
    }
}
