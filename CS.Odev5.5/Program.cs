using System;

namespace CS.Odev5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.Name = "Serpil";
            player.Surname = "TY";
            player.NationalityId = 123490908;
            player.DateOfBirth = new DateTime(1981,10,01);

            PlayerManager playerManager = new PlayerManager();
            playerManager.ValidateAndSave(player);
            playerManager.DeletePlayer(player);

            CampaignManager campaignManager = new CampaignManager();

            GameManager gameManager = new GameManager();
            gameManager.SellGame(player);
            gameManager.SellGame(campaignManager);
            
        }
    }
}
