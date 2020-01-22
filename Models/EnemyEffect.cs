namespace lord_of_death
{
    public class EnemyEffect
    {
        private int damage = 0;
        private int hits = 0;
        private int venom = 0; //once inflicted damage increases exponentially per turn(then drains energy?)
        private bool pierce = false; // double damage against shield
        private int energyLoss = 0;
        private int snare = 0; //snare prevents dodge, can stack, remove 1 per turn
        private int bleed = 0; // same as poison in slay the spire
        private int crush = 0; //actions take double energy
        public int Damage { get => damage; set => damage = value; }
        public int Hits { get => hits; set => hits = value; }
        public int Venom { get => venom; set => venom = value; }
        public bool Pierce { get => pierce; set => pierce = value; }
        public int EnergyLoss { get => energyLoss; set => energyLoss = value; }
        public int Snare { get => snare; set => snare = value; }
        public int Bleed { get => bleed; set => bleed = value; }
        public int Crush { get => crush; set => crush = value; }

        public EnemyEffect()
        {

        }
    }
}