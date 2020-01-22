using System;
using System.Collections.Generic;
using System.Linq;

namespace lord_of_death
{

    public class Dealer
    {
        private List<Card> drawPile;
        private List<Card> discardPile;
        private List<Card> currentHand;

        private int handSize = 0;
        private static Random rnd = new Random();

        public List<Card> GetCurrentHand()
        {
            var hand = new List<Card>();
            hand.AddRange(currentHand);
            return hand;
        }

        public List<Card> GetDiscardPile()
        {
            var hand = new List<Card>();
            hand.AddRange(discardPile);
            return hand;
        }

        public List<Card> GetDrawPile()
        {
            var hand = new List<Card>();
            hand.AddRange(drawPile);
            return hand;
        }


        public Dealer(List<Card> cards, int handSize)
        {
            this.handSize = handSize;
            drawPile = new List<Card>();
            cards = addCardIds(cards);
            drawPile.AddRange(cards);
            discardPile = new List<Card>();
            currentHand = new List<Card>();
        }

        private List<Card> addCardIds(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                var card = cards[i];
                card.Id = i;
            }
            return cards;
        }

        // public void drawRandom(int count = 4)
        // {
        //     for (int i = 0; i < count; i++)
        //     {

        //         if (drawPile.Count == 0)
        //         {
        //             //if discard and draw pile are empty, do nothing
        //             if (discardPile.Count == 0)
        //             {
        //                 break;
        //             }
        //             drawPile.AddRange(discardPile);
        //             discardPile.Clear();
        //         }

        //         int r = rnd.Next(drawPile.Count);
        //         currentHand.Add(drawPile[r]);
        //         drawPile.RemoveAt(r);
        //     }
        // }

        public void DrawHand()
        {
            for (int i = 0; i < handSize; i++)
            {
                if (drawPile.Count == 0)
                {

                    if (discardPile.Count > 0)
                    {

                        //put discard pile into draw pile
                        drawPile.AddRange(discardPile);
                        discardPile.Clear();
                        ShuffleDrawPile();
                    }
                }
                if (drawPile.Count > 0)
                {
                    currentHand.Add(drawPile[0]);
                    drawPile.RemoveAt(0);
                }
                else
                {
                    //no cards available to draw
                }
            }
        }

        public void ShuffleDrawPile()
        {
            for (int i = drawPile.Count; i > 1; i--)
            {
                int r = rnd.Next(i);
                var value = drawPile[r];
                drawPile[r] = drawPile[i - 1];
                drawPile[i - 1] = value;
            }

        }

        public void DiscardHand()
        {
            discardPile.AddRange(currentHand);
            currentHand.Clear();
        }
        public void Discard(int cardId)
        {
            var selectedCard = currentHand.FirstOrDefault(c => c.Id == cardId);
            if (selectedCard != null)
            {
                currentHand.Remove(selectedCard);
                discardPile.Add(selectedCard);
            }
        }

        public void DisplayPileCount()
        {
            Console.WriteLine();
            Console.WriteLine("{0}🃏 {1}🎴 --------------------------------------------------------------", drawPile.Count, discardPile.Count);
        }

        public void DisplayCurrentHand()
        {
            int cardNumber = 1;
            Console.WriteLine();
            foreach (var card in currentHand)
            {
                Console.WriteLine("[{0}] {1}⚡ {2} {3}- {4}\n",
                    cardNumber, card.AllyEffect.EnergyCost, card.Name, card.EffectDisplay(), card.Description);

                cardNumber++;
            }
        }
    }
}