using GameSalesSimulationProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Entities
{
    public class Offer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int discountRate { get; set; }

    }
}
