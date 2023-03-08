using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Gamer> gamers = new List<Gamer>();
            List<Game> games = new List<Game>();
            List<Campaign> campaigns = new List<Campaign>();

            gamers.Add(new Gamer { FirstName = "Alperen", LastName = "Dagli", NationalityId = "12345", BirthDate = new DateTime(2000, 07, 15), Id = 1 });

            IGamerService gamerManager = new GamerManager(new GamerCheckManager());
            foreach (var gamer in gamers)
            {
                gamerManager.Add(gamer);
            }


            games.Add(new Game { Name = "The Witcher 3", Price = 300, Id = 1 });
            IGameService gameManager = new GameManager();
            foreach (var game in games)
            {
                gameManager.Add(game);
            }

            campaigns.Add(new Campaign() { Id = 1, Name = "Sommer Sale" });
            ICampaignService campaignManager = new CampaignManager();
            foreach (var campaign in campaigns)
            {
                campaignManager.Add(campaign);
            }

            gameManager.Sell(games[0], gamers[0]);

            Console.ReadKey();

        }
    }
}
