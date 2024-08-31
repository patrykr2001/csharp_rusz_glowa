namespace ObliczanieObrazekConsole
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        

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

        public ArrowDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal baseDamage = BASE_MULTIPLIER * roll;
            baseDamage = (int)(baseDamage * (Magic ? MAGIC_MULTIPLIER : 1m));
            Damage = (int)Math.Ceiling(Flaming ? FLAME_DAMAGE + baseDamage : baseDamage);
        }

    }
}