using System;

namespace Cs.Odev._5._5.Katmanlı
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Gamer Ahmet = new Gamer()
            {
                DateOfBirth = new DateTime(1979, 07, 15),
                FirstName = "Ahmet",
                LastName = "TY",
                IdentityNumber = 12345

            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer()
            {
                DateOfBirth = new DateTime(1981, 10, 01),
                FirstName = "SERPİL",
                LastName = "TY",
                IdentityNumber = 12345

            });
            CampaignManager campaign = new CampaignManager();
            OrderManager orderManager = new OrderManager();
            orderManager.Order(Ahmet);


            orderManager.Order(Ahmet, campaign);
            campaign.NewCampaign();
            campaign.UpdateCampaign();
            campaign.RemoveCampaign();

        }
    }
}
