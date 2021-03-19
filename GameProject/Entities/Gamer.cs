﻿using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public String TCNO { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String BirthYear { get; set; }
    }
}
