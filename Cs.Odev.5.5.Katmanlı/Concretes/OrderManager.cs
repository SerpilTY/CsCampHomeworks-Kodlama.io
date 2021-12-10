using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Odev._5._5.Katmanlı
{
    class OrderManager
    {
  
        public void Order(Gamer gamer, ICampaignService campaignService) {

            campaignService.RunCampaign();

            Console.WriteLine("To the player named as "+gamer.FirstName+" "+gamer.LastName+" "+ " " +
                "above campaign action defined succesfully.");

        }
    }
}
