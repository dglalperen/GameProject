using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine($"Added Gamer: {gamer.FirstName}");
            } else
            {
                Console.WriteLine($"Could not add Gamer: {gamer.FirstName}");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine($"Removed Gamer: {gamer.FirstName}");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"Updated Gamer: {gamer.FirstName}");
        }
    }
}
