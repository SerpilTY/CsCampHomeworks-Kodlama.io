using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Odev._5._5.Katmanlı
{
    class CampaignManager : ICampaignService

    {
        public void NewCampaign()

        { Console.WriteLine("Game Ordered Succesfully!"); }

        

        public void RemoveCampaign()

        { Console.WriteLine("Campaign Removed Successfully!"); }
              

        public void UpdateCampaign()
        {
            Console.WriteLine("Campaign Updated Successfully!");
        }
    }
}
