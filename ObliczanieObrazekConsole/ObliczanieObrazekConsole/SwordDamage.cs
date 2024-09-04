namespace ObliczanieObrazekConsole
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public SwordDamage(int roll) : base(roll) { }

        protected override void CalculateDamage()
        {
            Damage = (int)(Roll * (Magic ? 1.75m : 1m)) + BASE_DAMAGE + (Flaming ? FLAME_DAMAGE : 0);
        }
    }
}
