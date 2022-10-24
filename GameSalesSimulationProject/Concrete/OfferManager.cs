using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + " eklendi.");
        }
    }
}
