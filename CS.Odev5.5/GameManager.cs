using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Odev5._5
{
    class GameManager
    {
        public void SellGame(Player player)
        {
            Console.WriteLine("Game selled to "+ player.Name+" "+ player.Surname);
        }

        public void SellGame(CampaignManager campaignManager) {

            campaignManager.NewCampaign();
        }
    }
}
