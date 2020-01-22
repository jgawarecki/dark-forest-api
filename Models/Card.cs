using System.Collections.Generic;

namespace lord_of_death
{
    public class Card : BattleAct
    {
        public int Id = -1;
        private int level = 0;//level is capped by rank
        private int xp = 0;//each time a card is played it gains xp
        private int rank = 0;//combine multiple cards to rank up
        private int rarity = 0;

        private List<BattleAct> possibleBattleActs;
    }
}