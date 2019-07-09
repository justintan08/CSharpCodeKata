using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class BlueCompare : Award
    {
        public override string Name { get { return "Blue Compare"; } }

        public BlueCompare(int sellIn, int quality) : base(sellIn, quality) { }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
                if (Quality < 50 && SellIn < 11)
                {
                    Quality++;
                }
                if (Quality < 50 && SellIn < 6)
                {
                    Quality++;
                }
            }
            SellIn--;
            if (SellIn < 0)
            {
                Quality-=Quality;
            }
        }
    }
}
