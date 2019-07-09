using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    public class BlueDistinctionPlus : Award
    {
        public override string Name { get { return "Blue Distinction Plus"; } }

        public BlueDistinctionPlus(int sellIn, int quality) : base(sellIn, quality) { }

        public override void UpdateQuality()
        {
            //Quality never changes
        }
    }
}
