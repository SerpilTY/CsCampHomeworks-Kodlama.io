using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Odev._5._5.Katmanlı
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "SERPİL" && gamer.LastName == "TY" && 
                gamer.DateOfBirth==new DateTime(1981,10,01) && gamer.IdentityNumber==12345 )
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
