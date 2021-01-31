using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformProject.Abstract;
using GamePlatformProject.Entities;

namespace GamePlatformProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya sisteme eklendi!");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya sistemden silindi.");
        }
    }
}
