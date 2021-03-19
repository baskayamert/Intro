using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign, Game game);
        void Delete(Campaign campaign, Game game);
        void Update(Campaign campaing, int newDiscount);
    }
}
