using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public String Name { get; set; }
        public int Discount { get; set; }
    }
}
