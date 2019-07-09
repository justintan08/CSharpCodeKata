using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    public abstract class Award
    {
        public abstract string Name { get; }
        
        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Award(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public virtual void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }
            SellIn--;
            if (Quality > 0 && SellIn < 0)
            {
                Quality--;
            }
        }

        public void PrintCurrentState()
        {
            System.Console.WriteLine($"Name: {Name}; Quality: {Quality}; SellIn: {SellIn}");
        }
    }
}
