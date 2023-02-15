using GameSimulation.Abstracts;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name +" "+ "oyunu eklenmiştir.");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " " + "oyunu güncellenmiştir.");
        }
        public void Delete (Game game)
        {
            Console.WriteLine(game.Name + " " + "oyunu silinmiştir.");
        }

       
    }
}
