using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class BlueFirst : Award
    {
        public override string Name { get { return "Blue First"; } }

        public BlueFirst(int sellIn, int quality) : base(sellIn, quality) { }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
            SellIn--;
            if (Quality < 50 && SellIn < 0)
            {
                Quality++;
            }
        }
    }
}
