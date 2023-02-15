using GameSimulation.Abstracts;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class GamerManager:IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName+gamer.LastName+" "+"oyuncu eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Oyuncu gerçek bir oyuncu değildir.");
            }
        }
        public void Update(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + gamer.LastName + " "+ "oyuncu güncellenmiştir.");
            }
            else
            {
                Console.WriteLine("Oyuncu gerçek bir oyuncu değildir.");
            }
        }
        public void Delete (Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " "+  "oyuncu silinmiştir.");
        }
    }
}
