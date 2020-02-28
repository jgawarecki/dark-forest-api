namespace lord_of_death
{
    public class BattleAct
    {
        private string name;
        private string description;
        private AllyEffect allyEffect;
        private EnemyEffect enemyEffect;
        public string Name { get => name; set => name = value; }
        internal AllyEffect AllyEffect { get => allyEffect; set => allyEffect = value; }
        internal EnemyEffect EnemyEffect { get => enemyEffect; set => enemyEffect = value; }
        public string Description { get => description; set => description = value; }
        public BattleAct()
        {

        }
        public string EffectDisplay()
        {
            var dd = "";
            if (EnemyEffect.Damage > 0)
            {
                dd += EnemyEffect.Hits > 1 ? EnemyEffect.Hits + "x" + EnemyEffect.Damage + "💥 " : EnemyEffect.Damage + "💥 ";
            }
            dd += EnemyEffect.Venom > 0 ? EnemyEffect.Venom + "💉 " : "";
            dd += AllyEffect.Dodge > 0 ? AllyEffect.Dodge + "🔵 " : "";
            dd += AllyEffect.Shield > 0 ? AllyEffect.Shield + "🛡️  " : "";

            return dd;
        }
    }
}