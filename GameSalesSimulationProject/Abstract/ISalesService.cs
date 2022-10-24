using GameSalesSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesSimulationProject.Abstract
{
    public interface ISalesService
    {
        void Sale(User user, List<Game> games, Offer offer);

        void Sale(User user, Game game);

    }
}
