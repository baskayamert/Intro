using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Game : IEntity
    {
        public int GameId { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
    }
}
