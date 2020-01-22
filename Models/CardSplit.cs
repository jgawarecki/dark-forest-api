using System.Collections.Generic;

namespace lord_of_death
{
    public class CardSplit
    {
        public List<Card> DrawPile { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> DiscardPile { get; set; }
    }
}