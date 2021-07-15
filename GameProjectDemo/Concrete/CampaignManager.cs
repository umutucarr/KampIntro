using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya eklendi:" + campaigns.CampaignsName + " %" + campaigns.CampaignDiscount);
        }

        public void DeleteCampaign(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya silindi." + campaigns.CampaignsName + " %" + campaigns.CampaignDiscount);

        }

        public void UpdateCampaign(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya güncellendi: " + campaigns.CampaignsName + " " + campaigns.CampaignDiscount);
        }
    }
}
