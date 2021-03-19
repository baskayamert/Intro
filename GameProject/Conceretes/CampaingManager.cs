using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaingManager : ICampaignService
    {

        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Price of " + game.Name + " is " + game.Price + "TL");
            Console.WriteLine("The campaign " + campaign.Name + " was applied to " + game.Name + " as " + campaign.Discount + "%");
            Console.WriteLine("Current price of " + game.Name + " is " + (game.Price * (100 - campaign.Discount) / 100 )  + "TL");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("The campaign " + campaign.Name + " successfully deleted for " + game.Name + "!");
        }

        public void Update(Campaign campaign, int newDiscount)
        {
            campaign.Discount = newDiscount;
            Console.WriteLine("The campaign " + campaign.Name + " successfully updated as " + campaign.Discount + "% discount!");
        }
    }
}
