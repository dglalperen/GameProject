using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine($"Added Campaign: {campaign.Name}");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine($"Removed Campaign: {campaign.Name}");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"Updated Campaign: {campaign.Name}");
        }
    }
}
