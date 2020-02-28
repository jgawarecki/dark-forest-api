using System;
using System.Collections.Generic;
using System.Linq;

namespace lord_of_death
{
    class FlowOfBattle
    {
        public static bool DoBattle(Combatant player, List<Combatant> monsters)
        {
            var battlefield = new Battlefield(CombatantData.SummonPlayer(), monsters.First());
            var dealer = new Dealer(CardData.GetActiveDeck(), 4);
            dealer.ShuffleDrawPile();
            var battleContinues = true;
            var playerSurvives = false;
            while (battleContinues)
            {
                var playerWins = doPlayersTurn(battlefield, dealer);
                if (playerWins)
                {
                    playerSurvives = true;
                    break;
                }
                var monsterFought = battlefield.DoMonsterTurn();
                var monsterWins = battlefield.IsBattleConcluded();
                if (monsterWins)
                {
                    battleContinues = false;
                    playerSurvives = false;
                    break;
                }
            }
            return playerSurvives;
        }

        private static bool doPlayersTurn(Battlefield battlefield, Dealer dealer)
        {
            dealer.DrawHand();
            dealer.DisplayPileCount();

            battlefield.PlayerBeginsTurn();
            battlefield.DisplayCombatants();

            bool isPlayersTurn = true;
            while (isPlayersTurn)
            { // do player actions
                var hand = dealer.GetCurrentHand();
                dealer.DisplayCurrentHand();
                //battlefield.DisplayCombatants();
                var pick = readPlayersPick(hand);

                if (pick == -1)
                {
                    isPlayersTurn = false;
                }
                else
                {
                    //play card
                    var cardPicked = hand[pick - 1];
                    bool isGoodAction = battlefield.DoPlayerAction(cardPicked as BattleAct);

                    if (isGoodAction)
                    {
                        if (battlefield.IsBattleConcluded())
                        {
                            return true;
                        }
                        dealer.Discard(cardPicked.Id);
                        dealer.DisplayPileCount();
                        battlefield.DisplayCombatants();

                    }
                }
            }

            dealer.DiscardHand();
            battlefield.PlayerEndsTurn();
            return battlefield.IsBattleConcluded();
        }

        private static int readPlayersPick(List<Card> hand)
        {
            int play = -1;
            bool needValidInput = true;
            while (needValidInput)
            {
                var playInput = Console.ReadLine();
                if (playInput == ".")
                {
                    return -1;
                }
                if (!Int32.TryParse(playInput, out play) || (play <= 0 || play > hand.Count))
                {
                    if (hand.Count == 0)
                    {
                        Console.WriteLine("end your turn with '.'");
                    }
                    else
                    {
                        Console.WriteLine("Choose a card between {0} and {1} or end your turn with '.'", 1, hand.Count);
                    }
                }
                else
                {
                    needValidInput = false;
                }
            }
            return play;
        }


    }
}
