using System.Collections.Generic;

namespace lord_of_death
{
    class DarkForest
    {
        public static void EnterTheWoods()
        {
            var monsters = new List<Combatant>();

            monsters.Add(CombatantData.SummonScrawnyBeastman());
            var stillAlive = FlowOfBattle.DoBattle(CombatantData.SummonPlayer(), monsters);
            monsters.Clear();

            if (stillAlive)
            {
                monsters.Add(CombatantData.SummonTreent());
                stillAlive = FlowOfBattle.DoBattle(CombatantData.SummonPlayer(), monsters);
                monsters.Clear();
            }

            if (stillAlive)
            {
                monsters.Add(CombatantData.SummonBloodworm());
                stillAlive = FlowOfBattle.DoBattle(CombatantData.SummonPlayer(), monsters);
                monsters.Clear();
            }

            if (stillAlive)
            {
                monsters.Add(CombatantData.SummonSpider());
                stillAlive = FlowOfBattle.DoBattle(CombatantData.SummonPlayer(), monsters);
                monsters.Clear();
            }
        }
    }
}