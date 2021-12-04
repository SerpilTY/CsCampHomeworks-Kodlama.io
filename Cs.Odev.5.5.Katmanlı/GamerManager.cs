using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Odev._5._5.Katmanlı
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }


        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer Added!");
            }
            else

            { Console.WriteLine("Gamer Validation Failed!"); }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated!");
        }
    }
}

