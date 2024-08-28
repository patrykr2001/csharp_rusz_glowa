using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanapki
{
    internal class MenuItem
    {
        public Random Randomizer = new Random();

        public string[] Proteins = { "Wołowina", "Salami", "Indyk", "Szynka", "Pastrami", "Tofu" };
        public string[] Condiments = { "musztarda żółta", "musztarda brązowa", "musztarda miodowa", "majonez", "przyprawy",
            "sos francuski" };
        public string[] Breads = { "ryżowe", "białe", "pszenne", "pumpernikiel", "bułka" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = randomProtein + " i " + randomCondiment + ". Pieczywo: " + randomBread + ".";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01m);
            Price = price.ToString("c");
        }
    }
}
