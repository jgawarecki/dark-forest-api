using System;
using System.Collections.Generic;

namespace lord_of_death
{
    public class Combatant
    {
        #region Private Fields
        private string name;
        private int level;
        private int maxHealth = 0;
        private int maxEnergy = 0;
        private int health = 0;
        private int energy = 0;
        private int energyGainPerTurn = -1;
        private BattleCircuit battleCircuit = new BattleCircuit();
        private int battleCircuitIndex = 0;
        private string imgName;
        #endregion

        public bool IsAlive { get => health > 0; }
        public string Name { get => name; set => name = value; }
        public string ImgName { get => imgName; set => imgName = value; }
        private AllyStatus allyStatus = new AllyStatus();
        private EnemyStatus enemyStatus = new EnemyStatus();
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }

        public int Level { get => level; set => level = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int MaxEnergy { get => maxEnergy; set => maxEnergy = value; }
        public int EnergyGainPerTurn { get => energyGainPerTurn == -1 ? maxEnergy : energyGainPerTurn; set => energyGainPerTurn = value; }
        public BattleCircuit BattleCircuit { get => battleCircuit; set => battleCircuit = value; }
        public AllyStatus AllyStatus { get => allyStatus; set => allyStatus = value; }
        public EnemyStatus EnemyStatus { get => enemyStatus; set => enemyStatus = value; }

        // public void BeginningPhase()
        // {
        //     Energy = MaxEnergy;
        //     AllyStatus.Dodge = 0;
        // }
        // public void ConsumePoisonStack()
        // {

        // }
        public bool DoAllyEffects(BattleAct action)
        {
            if (Energy < action.AllyEffect.EnergyCost)
            {
                Console.WriteLine("{0} can't summon the energy", Name);
                return false;
            }
            Energy -= action.AllyEffect.EnergyCost;
            AllyStatus.Dodge += action.AllyEffect.Dodge;
            AllyStatus.Shield += action.AllyEffect.Shield;
            Energy += action.AllyEffect.EnergyGained;
            //if ()
            //this.combatActionPlayed.Add(combatAction);
            return true;
        }
        public void DoEnemyEffects(BattleAct action)
        {
            for (int i = 0; i < action.EnemyEffect.Hits; i++)
            {
                if (AllyStatus.Dodge > 0)
                {
                    AllyStatus.Dodge--;
                    Console.WriteLine("Dodge! 🔵");
                }
                else
                {
                    var damage = action.EnemyEffect.Damage;
                    if (AllyStatus.Shield > 0)
                    {
                        if (action.EnemyEffect.Pierce)
                        {
                            damage = damage * 2;
                        }
                        if (damage > AllyStatus.Shield)
                        {
                            var remainingDamage = action.EnemyEffect.Pierce ? (damage - AllyStatus.Shield) / 2 : damage - AllyStatus.Shield;
                            AllyStatus.Shield = 0;
                            health -= remainingDamage;
                        }
                        else
                        {
                            AllyStatus.Shield -= damage;
                            Console.WriteLine("Blocked {0}🛡️", damage);
                        }
                    }
                    else
                    {
                        health -= action.EnemyEffect.Damage;
                        Console.WriteLine("{0}! ({1}💥)", action.Name, action.EnemyEffect.Damage);
                        EnemyStatus.Venom += action.EnemyEffect.Venom;
                    }
                }
            }
        }
        public void UpdateBattleCircuit()
        {
            battleCircuit.Update(this);
            // battleCircuitIndex++;

            // if (battleCircuitIndex >= battleCircuit.Count)
            // {
            //     battleCircuitIndex = 0;
            // }
        }
        public BattleAct GetNextBattleAct()
        {
            return battleCircuit.GetNext();
            //return battleCircuit[battleCircuitIndex];
        }
    }
}