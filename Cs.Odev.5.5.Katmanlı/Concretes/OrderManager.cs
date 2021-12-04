using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Odev._5._5.Katmanlı
{
    class OrderManager
    {
       
        public void Order(Gamer gamer) {
            Console.WriteLine("Order accepted from Gamer, to Gamer:" + gamer.FirstName+" " +gamer.LastName);
        }

        public void Order(Gamer gamer, CampaignManager campaignManager ) {

            Console.WriteLine("Order accepted from Gamer, named as:" + gamer.FirstName + " " + gamer.LastName + " selled by campaign ");
        }
        }
}
