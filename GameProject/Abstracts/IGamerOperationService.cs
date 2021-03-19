using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGamerOperationService
    {
        void SignUp(Gamer newGamer);
        void Update(Gamer gamer);
        void DeleteAccount(Gamer gamer);

    }
}
