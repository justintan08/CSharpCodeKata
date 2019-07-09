using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderQuality.Console
{
    class ACMEPartnerFacility : Award
    {
        public override string Name { get { return "ACME Partner Facility"; } }

        public ACMEPartnerFacility(int sellIn, int quality) : base(sellIn, quality) { }

    }
}
