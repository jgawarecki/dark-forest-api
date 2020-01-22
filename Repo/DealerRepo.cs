using lord_of_death;

namespace dark_forest_api
{
    public class DealerRepo
    {
        public static Dealer CurrentDealer { get; set; }

        public static void DealerSetup()
        {
            CurrentDealer = new Dealer(CardData.GetActiveDeck(), 4);
            CurrentDealer.ShuffleDrawPile();
        }

    }
}