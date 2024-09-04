namespace ObliczanieObrazekConsole
{
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        public ArrowDamage(int roll) : base(roll) { }

        protected override void CalculateDamage()
        {
            decimal baseDamage = BASE_MULTIPLIER * Roll;
            baseDamage = (int)(baseDamage * (Magic ? MAGIC_MULTIPLIER : 1m));
            Damage = (int)Math.Ceiling(Flaming ? FLAME_DAMAGE + baseDamage : baseDamage);
        }

    }
}