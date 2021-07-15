using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyunlar---------------------------------------
            Game game1 = new Game();
            game1.GameCategories = "War";
            game1.GameName = "Call Of Duty";
            game1.GamePrice = 100;

            Game game2 = new Game();
            game2.GameCategories = "Race";
            game2.GameName = "Need For Speed";
            game2.GamePrice = 10;

            Game game3 = new Game();
            game3.GameCategories = "Simulation";
            game3.GameName = "Euro Truck Simulator";
            game3.GamePrice = 50;
            //Oyuncular---------------------------------------
            Gamer gamer1 = new Gamer();
            gamer1.Id = "1212311";
            gamer1.FirstName = "Umut";
            gamer1.LastName = "UÇAR";
            gamer1.DateOfBirt = new DateTime(1998, 7, 24);

            Gamer gamer2 = new Gamer();
            gamer2.Id = "132323211";
            gamer2.FirstName = "Engin";
            gamer2.LastName = "Demiroğ";
            gamer2.DateOfBirt = new DateTime(1985, 1, 15);

            Gamer gamer3 = new Gamer();
            gamer3.Id = "1323232323211";
            gamer3.FirstName = "Ahmet";
            gamer3.LastName = "Yılmaz";
            gamer3.DateOfBirt = new DateTime(1980, 10, 11);
            //Kampanyalar--------------------------------------
            Campaigns campaigns1 = new Campaigns();
            campaigns1.CampaignsName = "Oyuncu İndirimi";
            campaigns1.CampaignDiscount =20 ;

            Campaigns campaigns2 = new Campaigns();
            campaigns2.CampaignsName = "Karne İndirimi";
            campaigns2.CampaignDiscount = 50;
            
            //Oyun ekleme--------------------------------------
            Console.WriteLine("******************************");
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Delete(game3);
            Console.WriteLine("******************************");
            //Kampanya ekleme
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaigns1);
            campaignManager.AddCampaign(campaigns2);
            //Oyuncu ekleme--------------------------------------
            Console.WriteLine("******************************");
            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Register(gamer1);
            gamerManager.Register(gamer2);
            gamerManager.Register(gamer3);
            Console.WriteLine("******************************");
            //Satışlar-----------------------------------------
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game1,gamer1,campaigns1);
            Console.WriteLine("******************************");










        }
    }
}
