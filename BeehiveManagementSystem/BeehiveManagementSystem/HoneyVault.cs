using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        private readonly static float NECTAR_CONVERSION_RATIO = .19f;
        private readonly static float LOW_LEVEL_WARNING = 10f;

        private static float _honey = 25f;
        private static float _nectar = 100f;

        public static string StatusReport { get
            {
                string report = string.Empty;
                report += $"Ilość miodu: {_honey}\n";
                report += $"Ilość nektaru: {_nectar}\n";

                if (_honey <= LOW_LEVEL_WARNING) report += "MAŁO MIODU - DODAJ PRODUCENTÓW MIODU\n";
                if (_nectar <= LOW_LEVEL_WARNING) report += "MAŁO NEKTARU - DODAJ PRODUCENTÓW NEKTARU\n";

                return report;
            } }

        public static void ConvertNectarToHoney(float amount)
        {
            if(amount > _nectar) amount = _nectar;
            _nectar -= amount;
            _honey += amount * NECTAR_CONVERSION_RATIO; 
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount > _honey) return false;
            _honey -= amount;
            return true;
        }

        public static void CollectNectar(float amount)
        {
            if(amount > 0f) _nectar += amount;
        }
    }
}
