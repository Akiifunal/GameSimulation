using GameSimulation.Abstracts;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class SaleManager:ISaleService
    {
        public void Add(Game game, Gamer gamer, Campaign campaign)
        {
            double bill;
            double fee;
            bill = (game.Price * campaign.Discount) / 100;
            fee = game.Price - bill;
            Console.WriteLine("Oyun" +" "+ gamer.FirstName + gamer.LastName+ " "+"adlı kişiye" +" "+ fee+ " " +" fiyatıyla satılmıştır.");

        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name +" "+"oyun satışı silinmiştir.");
        }

    }
}
