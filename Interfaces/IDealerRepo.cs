namespace lord_of_death
{
    public interface IDealerRepo
    {
        void Setup();
        CardSplit GetCurrentSplit();
        void DiscardHand();
        void Discard(string cardId);
        void DrawHand();
        Card GetCard(string cardId);
    }
}
