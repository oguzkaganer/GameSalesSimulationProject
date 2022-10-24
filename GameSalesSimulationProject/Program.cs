using GameSalesSimulationProject.Abstract;
using GameSalesSimulationProject.Adapters;
using GameSalesSimulationProject.Concrete;
using GameSalesSimulationProject.Entities;

namespace GameSalesSimulationProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Id = 1,
                FirstName = "Oğuz Kağan",
                LastName = "ER",
                DateofBirth = new DateTime(1994, 03, 27),
                NationalityId = "***",
                Username="oguz",
                Password="1234"

            };


            Game game1 = new Game()
            {
                Id=1,
                Name = "League of Legends",
                Price = 249.9
            };
            Game game2 = new Game() { Id = 1, Name = "Volarant", Price = 139.9 };

            List<Game> games = new List<Game>()
            {
                game1,game2
            };

            Offer offer1 = new Offer()
            {
                Id=1,
                Name="Yaz Kampanyası",
                discountRate=70
            };

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer1);
            Console.WriteLine();

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(user1, game1);

            Console.WriteLine();

            salesManager.Sale(user1, games, offer1);
            Console.WriteLine();

            BaseUserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Save(user1);


            Console.ReadLine();
        }
    }
}