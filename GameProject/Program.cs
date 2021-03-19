using GameProject.Conceretes;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Id = 1, TCNO = "12345678",Name="MERT",Surname="BAŞKAYA",BirthYear="1999" };
            GamerOperationManager gamerOperationManager = new GamerOperationManager(new AccountVerifierManager());
            gamerOperationManager.SignUp(gamer);

            BaseGameSaleManager baseGameSaleManager = new BaseGameSaleManager();
            baseGameSaleManager.Sell(gamer, new Game() { GameId = 1, Name = "COD", Price = 80 });

            ICampaignService campaignManager = new CampaingManager();
            GameSaleManager gameSaleManager = new GameSaleManager(campaignManager , new Campaign() { CampaignId = 1, Discount = 15, Name = "Almost For Free" });
            gameSaleManager.Sell(gamer, new Game() { GameId = 2, Name = "Battlefield", Price = 100 });
        }
    }
}
