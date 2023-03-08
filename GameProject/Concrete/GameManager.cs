using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine($"Added Game: {game.Name}");
        }

        public void Remove(Game game)
        {
            Console.WriteLine($"Removed Game: {game.Name}");
        }

        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine($"Sold Game: {game.Name} for {game.Price} to {gamer.FirstName}");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"Updated Game: {game.Name}");
        }
    }
}
