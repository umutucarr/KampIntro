using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameSaleManager : IGameSaleService

    {
        public void Sale(Game game, Gamer gamer, Campaigns campaigns)
        {
            double newPrice = game.GamePrice-(((game.GamePrice)*campaigns.CampaignDiscount)/100);
            Console.WriteLine
                (game.GameName + " adlı oyunu " + 
                 gamer.FirstName +" "+gamer.LastName +" adlı oyuncu " + 
                 newPrice + " TL'ye satın aldı."+ Environment.NewLine
                 + "Kullanılan Kampanya: "+campaigns.CampaignsName+ Environment.NewLine
                 + "Kullanılan İndirim: %" + campaigns.CampaignDiscount+ Environment.NewLine
                 + "İndirimsiz Fiyatı: "+game.GamePrice+" TL");
            

        }
    }
}
