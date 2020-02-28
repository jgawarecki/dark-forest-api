using System.Collections.Generic;

namespace lord_of_death
{
    public class CardSplit
    {
        public List<Card> DrawPile { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> DiscardPile { get; set; }
        public CardSplit(List<Card> draw, List<Card> hand, List<Card> discard)
        {
            DrawPile = draw;
            Hand = hand;
            DiscardPile = discard;
        }
    }
}