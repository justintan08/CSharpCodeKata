using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class BlueStar : Award
    {
        public override string Name { get { return "Blue Star"; } }

        public BlueStar(int sellIn, int quality) : base(sellIn, quality) { }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality -= 2;
            }
            SellIn--;
            if (Quality > 0 && SellIn < 0)
            {
                Quality -= 2;
            }
        }
    }
}
