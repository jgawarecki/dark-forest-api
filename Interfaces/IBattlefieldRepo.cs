using System.Collections.Generic;

namespace lord_of_death
{
    public interface IBattlefieldRepo
    {
        void Setup();
        void StartTurn();
        void PlayCard(Card card);
        List<Combatant> GetFoes();
        List<Combatant> GetPlayers();

    }
}
