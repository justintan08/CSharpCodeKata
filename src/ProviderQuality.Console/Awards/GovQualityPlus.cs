using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class GovQualityPlus : Award
    {
        public override string Name { get { return "Gov Quality Plus"; } }

        public GovQualityPlus(int sellIn, int quality) : base(sellIn, quality) { }

    }
}
