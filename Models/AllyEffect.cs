namespace lord_of_death
{
    public class AllyEffect//switch allyeffect to implement allystatus
    {
        private int energyCost = 0;
        private int shield = 0;
        private int heal = 0;
        private int healOnHit = 0;
        private int dodge = 0;
        private int energyGained = 0;
        public int EnergyCost { get => energyCost; set => energyCost = value; }
        public int Shield { get => shield; set => shield = value; }
        public int Heal { get => heal; set => heal = value; }
        public int Dodge { get => dodge; set => dodge = value; }
        public int HealOnHit { get => healOnHit; set => healOnHit = value; }
        public int EnergyGained { get => energyGained; set => energyGained = value; }

        public AllyEffect()
        {

        }
    }
}