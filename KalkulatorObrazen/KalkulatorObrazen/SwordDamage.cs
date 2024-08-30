using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorObrazen
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        private int roll;
        private bool flaming;
        private bool magic;
        
        public int Damage {  get; private set; }

        public int Roll
        {
            get { return roll; } 
            set { 
                roll = value;
                CalculateDamage();
            }
        }

        public bool Flaming {  
            get { return flaming; } 
            set { 
                flaming = value; 
                CalculateDamage();
            } 
        }
        
        public bool Magic {  
            get { return magic; } 
            set { 
                magic = value; 
                CalculateDamage();
            } 
        }

        public SwordDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            Damage = (int)(Roll * (Magic ? 1.75m : 1m)) + BASE_DAMAGE + (Flaming ? FLAME_DAMAGE : 0);
        }

        
    }
}
