using System;
using System.Collections.Generic;

namespace lord_of_death
{
    class Battlefield
    {
        private Combatant player;
        private Combatant monster1;
        private Combatant monster2;
        private Combatant monster3;
        internal Combatant Player { get => player; }
        internal Combatant Monster1 { get => monster1; }

        public Battlefield(Combatant player, List<Combatant> monsters)
        {
            this.player = player;
            this.monster1 = monsters[0];
            // this.monster2 = monster2;
            // this.monster3 = monster3;
            Console.WriteLine("{0} creeps out of the forest with preditory eyes", this.monster1.Name, this.monster1.Health);
            Console.WriteLine("{0} anticipates combat and envisions a strategy", player.Name, player.Health);
        }

        public void PlayerBeginsTurn()
        {
            doStartPhase(player);
        }

        public void PlayerEndsTurn()
        {
            doEndPhase(player);
        }

        public bool DoPlayerAction(BattleAct ba)
        {
            if (player.DoAllyEffects(ba))
            {
                //determine target 
                Combatant target = monster1;
                //target takes damage

                target.DoEnemyEffects(ba);

                return true;
                //target takes status effect
                //set player stance
            }
            return false;
        }

        public bool DoMonsterTurn()
        {

            doStartPhase(monster1);
            doMainPhase(monster1);
            doEndPhase(monster1);
            return true;
        }

        private bool doStartPhase(Combatant dude)
        {
            dude.Energy = 0;
            dude.Energy += dude.EnergyGainPerTurn;
            dude.Energy += dude.AllyStatus.EnergyGained;
            dude.AllyStatus.Dodge = 0;

            if (dude.EnemyStatus.Venom > 0)
            {
                dude.Health -= dude.EnemyStatus.Venom;
                Console.WriteLine("Poisoned! {0}💉", dude.EnemyStatus.Venom);
                dude.EnemyStatus.Venom--;
            }
            //implement bleed
            return IsBattleConcluded();
        }

        private bool doMainPhase(Combatant dude)
        {
            dude.UpdateBattleCircuit();
            var ba = dude.GetNextBattleAct();
            dude.DoAllyEffects(ba);
            var target = player;
            target.DoEnemyEffects(ba);
            return IsBattleConcluded();
        }

        private bool doEndPhase(Combatant dude)
        {
            if (dude.EnemyStatus.Snare > 0)
            {
                dude.EnemyStatus.Snare--;
            }
            if (dude.EnemyStatus.Crush > 0)
            {
                dude.EnemyStatus.Crush--;
            }
            if (dude.EnemyStatus.EnergyLoss > 0)
            {
                dude.EnemyStatus.EnergyLoss = 0;
            }
            return IsBattleConcluded();
        }
        public bool IsBattleConcluded()
        {
            if (monster1.Health <= 0)
            {
                Console.WriteLine("{0} has been slain ☠", monster1.Name);
                return true;
            }
            if (player.Health <= 0)
            {
                Console.WriteLine("{0} has been slain ☠", player.Name);
                return true;
            }
            return false;
        }

        public void DisplayCombatants()
        {
            var monsterNextAction = monster1.GetNextBattleAct();
            //Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0} {1}⚡ {2}💕 -------------- {3} {4}💕 about to {5} {6}",
                                player.Name, player.Energy, player.Health, monster1.Name, monster1.Health, monsterNextAction.Name, monsterNextAction.EffectDisplay());
            Console.WriteLine("{0}🔵 {1}🛡️ {2}💉                       {3}🔵 {4}🛡️ {5}💉",
            player.AllyStatus.Dodge, player.AllyStatus.Shield, player.EnemyStatus.Venom, monster1.AllyStatus.Dodge, monster1.AllyStatus.Shield, monster1.EnemyStatus.Venom);
        }

    }
}