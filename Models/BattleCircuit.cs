using System.Collections.Generic;

namespace lord_of_death
{
    public class BattleCircuit
    {
        private List<BattleAct> highLoop = new List<BattleAct>();
        private List<BattleAct> midLoop = new List<BattleAct>();
        private List<BattleAct> lowLoop = new List<BattleAct>();
        // private List<BattleAct> desperateLoop = new List<BattleAct>();
        private List<BattleAct> currentLoop = new List<BattleAct>();

        private int highLoopIndex = 0;
        private int lowLoopIndex = 0;
        private int midLoopIndex = 0;
        // private int desperatetLoopIndex = 0;
        private int currentLoopIndex = 0;

        public List<BattleAct> AggroLoop { get => highLoop; set => highLoop = value; }
        internal List<BattleAct> ReservedLoop { get => midLoop; set => midLoop = value; }
        internal List<BattleAct> SupportiveLoop { get => lowLoop; set => lowLoop = value; }
        // internal List<BattleAct> DesperateLoop { get => desperateLoop; set => desperateLoop = value; }
        public List<BattleAct> CurrentLoop { get => currentLoop; set => currentLoop = value; }

        public void Update(Combatant dude)
        {

            var healthPercent = (dude.Health * 100) / dude.MaxHealth;
            var lowPercentRange = 10;
            var midPercentRange = 50;
            currentLoop.Clear();

            if (healthPercent > midPercentRange)
            {
                lowLoopIndex = 0;

            }
            else if (healthPercent > lowPercentRange)
            {

            }
            else
            {

            }

            //for now use aggro loop
            currentLoop.AddRange(highLoop);
            currentLoopIndex++;
            if (currentLoopIndex > currentLoop.Count)
            {
                currentLoopIndex = 0;
            }
        }

        public void Update()
        {
            currentLoop.AddRange(highLoop);
            currentLoopIndex++;
            if (currentLoopIndex > currentLoop.Count)
            {
                currentLoopIndex = 0;
            }
        }

        public BattleAct GetNext()
        {
            if (currentLoopIndex >= currentLoop.Count)
            {
                currentLoopIndex = 0;
            }
            if (currentLoop.Count == 0)
            {
                Update();
            }

            return currentLoop[currentLoopIndex];
        }
    }
}