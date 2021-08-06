using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;

        public Campaign() 
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert adv) 
        {
            _campaign.Add(adv);
        }

        public double GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {            
            foreach (Advert adv in _campaign)
               Console.WriteLine( adv.ToString());
            return " Total cost of campaign: " + Convert.ToString(GetCost());            
        }
    }
}