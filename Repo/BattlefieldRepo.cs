using System.Collections.Generic;
using lord_of_death;

namespace dark_forest_api
{
    public class BattlefieldRepo : IBattlefieldRepo
    {
        Battlefield battlefield;
        public void Setup()
        {
            var player = CombatantData.SummonPlayer();
            var monster = CombatantData.SummonSkele();
            battlefield = new Battlefield(player, monster);
        }

        public void StartTurn()
        {
            battlefield.PlayerBeginsTurn();
        }

        public void PlayCard(Card card)
        {
            battlefield.DoPlayerAction(card);
        }

        public List<Combatant> GetFoes()
        {
            return new List<Combatant>(){
                battlefield.Monster
            };
        }

        public List<Combatant> GetPlayers()
        {
            return new List<Combatant>(){
                battlefield.Player
            };
        }
    }
}