using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerOperationManager : IGamerOperationService
    {
        IAccountVerifierService _accountVerifierService;
        public GamerOperationManager(IAccountVerifierService accountVerifierService)
        {
            _accountVerifierService = accountVerifierService;
        }
        public void DeleteAccount(Gamer gamer)
        {
            Console.WriteLine("The account has been deleted successfully!");
        }

        public void SignUp(Gamer newGamer)
        {
            if (_accountVerifierService.Verify(newGamer))
            {
                Console.WriteLine("The gamer " + newGamer.Name + " successfully signed up!");
            }
            else
            {
                throw new Exception("Invalid person!");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The account has been updated successfully");
        }
    }
}
