using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformProject.Entities;

namespace GamePlatformProject.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);

    }
}
