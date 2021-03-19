using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Conceretes
{
    class GameSaleManager : BaseGameSaleManager
    {
        ICampaignService _campaignService;
        Campaign _campaign;

        public GameSaleManager(ICampaignService campaignService, Campaign campaign)
        {
            _campaign = campaign;
            _campaignService = campaignService;
        }
        public override void Sell(Gamer gamer, Game game)
        {
            _campaignService.Add(_campaign, game);
        }
    }
}
