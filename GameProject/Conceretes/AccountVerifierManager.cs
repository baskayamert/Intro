using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class AccountVerifierManager : IAccountVerifierService
    {
        public bool Verify(Gamer newGamer)
        {
            if(newGamer.TCNO == "12345678" && newGamer.Name == "MERT" && newGamer.Surname == "BAŞKAYA" && newGamer.BirthYear == "1999")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
