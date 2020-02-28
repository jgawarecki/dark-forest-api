using System.Linq;
using lord_of_death;

namespace dark_forest_api
{
    public class DealerRepo : IDealerRepo
    {
        private Dealer currentDealer { get; set; }

        public void Setup()
        {
            this.currentDealer = new Dealer(CardData.GetActiveDeck(), 4);
            this.currentDealer.ShuffleDrawPile();
        }
        public DealerRepo()
        {

        }

        public CardSplit GetCurrentSplit()
        {
            return new CardSplit(currentDealer.GetDrawPile(),
                                currentDealer.GetCurrentHand(),
                                currentDealer.GetDiscardPile());
        }

        public void DiscardHand()
        {
            this.currentDealer.DiscardHand();
        }


        public void Discard(string cardId)
        {
            this.currentDealer.Discard(cardId);
        }

        public void DrawHand()
        {
            this.currentDealer.DrawHand();
        }

        public Card GetCard(string cardId)
        {
            return currentDealer.Deck.FirstOrDefault(c => c.Id == cardId);
        }

    }
}