// See https://aka.ms/new-console-template for more information
using GameSimulation.Concrete;
using GameSimulation.Entities;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[]args)
        {
            Game game1 = new Game();
            game1.Id = 1234567889;
            game1.Name = "PES";
            game1.Price=99.9;

            Game game2=new Game();
            game2.Id = 12345699;
            game2.Name = "FIFA";
            game2.Price = 199.9;

            Gamer gamer1=new Gamer();
            gamer1.Id = 987654321;
            gamer1.FirstName = "Akif";
            gamer1.LastName = "Ünal";
            gamer1.UserNo = "123455666";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "İndirim vakti";
            campaign1.Discount = 15;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "İndirim vakti";
            campaign2.Discount = 15;



            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game2);

            SaleManager saleManager= new SaleManager();
            saleManager.Add(game2,gamer1,campaign2);
            saleManager.Add(game1, gamer1, campaign1);
            
            CampaignManager campaignManager= new CampaignManager();
            campaignManager.Add(campaign2);

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            gamerCheckManager.CheckIfRealPerson(gamer1);

        }
    }
}
