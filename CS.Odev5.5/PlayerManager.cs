using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Odev5._5
{
    class PlayerManager
    {
        public void ValidateAndSave(Player player)
        {
            if (CheckIfRealPerson(player))
            {
                Console.WriteLine("Player validated!");
            }
            else
            {
                throw new Exception("Not a Valid Person!");
            }
        }


        private bool CheckIfRealPerson(Player player)
        {   /*
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync(player.NationalityId, player.Name.ToUpper(), player.Surname.ToUpper(), player.DateOfBirth.Date);
            */
            return true;
            }

        public void RegisterToSystem(Player Player)
        {
            Console.WriteLine("Succesfully Registered");
        }

        public void UpdatePlayerInfo(Player player)
        {
            Console.WriteLine("Player Info Updated!");
        }

        public void DeletePlayer(Player player)
        {
            Console.WriteLine("Player Deleted!");
        }
       
    }
}
