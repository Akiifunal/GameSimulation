using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstracts
{
    public interface ISaleService
    {
        void Add(Game game, Gamer gamer, Campaign campaign);
        

         void Delete(Game game);
    }
   
}
