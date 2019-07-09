using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class TopConnectiveProviders : Award
    {
        public override string Name { get { return "Top Connected Providres"; } }

        public TopConnectiveProviders(int sellIn, int quality) : base(sellIn, quality) { }

    }
}
