using System.Collections.Generic;

namespace ProviderQuality.Console
{
    public class Program
    {
        public IList<Award> Awards
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Updating award metrics...!");

            var app = new Program()
            {
                Awards = new List<Award>
                {
                    new GovQualityPlus(10, 20),
                    new BlueFirst(2,0),
                    new ACMEPartnerFacility(5,7),
                    new BlueDistinctionPlus(0,80),
                    new BlueCompare(15,20),
                    new TopConnectiveProviders(3,6),
                    new BlueStar(8,50)
                }

            };


            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Awards.Count; i++)
            {
                Awards[i].PrintCurrentState();
                Awards[i].UpdateQuality();
                Awards[i].PrintCurrentState();
            }       
        }

    }

}
