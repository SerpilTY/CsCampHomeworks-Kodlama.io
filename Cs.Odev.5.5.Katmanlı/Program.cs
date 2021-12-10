using Cs.Odev._5._5.Katmanlı.Concretes;
using System;

namespace Cs.Odev._5._5.Katmanlı
{
    class Program
    {
        static void Main(string[] args)
            
        {

            Gamer Serpil = new Gamer()
            {
                DateOfBirth = new DateTime(1981, 10, 01), FirstName = "SERPİL", LastName = "TY", IdentityNumber = 12345
            };

            Gamer Ahmet = new Gamer()
            {
                DateOfBirth = new DateTime(1979, 07, 15), FirstName = "AHMET", LastName = "TY", IdentityNumber = 12345
            };
            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(Serpil);
            gamerManager.Add(Ahmet);
                     
            OrderManager orderManager = new OrderManager();

            orderManager.Order(Ahmet, new NewCampaignManager());
            orderManager.Order(Serpil, new UpdateCampaignManager());
            orderManager.Order(Ahmet, new RemoveCampaignManager());
         
        }
    }
}
