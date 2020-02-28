using System.Collections.Generic;

namespace lord_of_death
{
    public class BattleState
    {
        private CardSplit cardSplit;
        private List<Combatant> players;
        private List<Combatant> foes;
        public CardSplit CardSplit { get => cardSplit; set => cardSplit = value; }
        public List<Combatant> Players { get => players; set => players = value; }
        public List<Combatant> Foes { get => foes; set => foes = value; }

        public BattleState()
        { }
    }
}