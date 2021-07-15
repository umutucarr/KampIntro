using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService
    {
        public void AddCampaign(Campaigns campaigns);
        public void DeleteCampaign(Campaigns campaigns);
        public void UpdateCampaign(Campaigns campaigns);
    }
}
