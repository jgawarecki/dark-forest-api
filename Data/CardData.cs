using System.Collections.Generic;

namespace lord_of_death
{
    class CardData
    {
        public static List<Card> GetActiveDeck()
        {
            var deck = new List<Card> {
                 jab, jab, whack, whack, kick, kick, spinStrike, bolt, flip, flip, energyShield };
            return deck;
        }
        private static Card jab = new Card
        {
            Name = "Jab",
            Description = "jab staff with piercing blows",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 6,
                Hits = 1,
                Pierce = true
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };
        private static Card whack = new Card
        {
            Name = "Whack",
            Description = "whack with staff twice",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 4,
                Hits = 2
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        private static Card bolt = new Card
        {
            Name = "Bolt",
            Description = "unleash raw magick from palm",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 18,
                Hits = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2
            }
        };
        private static Card flip = new Card
        {
            Name = "Flip",
            Description = "dodge next hit with style",
            EnemyEffect = new EnemyEffect()
            {
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Dodge = 1
            }
        };

        private static Card spinStrike = new Card
        {
            Name = "Spin Strike",
            Description = "whirl staff at all foes",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 6,
                Hits = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };
        private static Card kick = new Card
        {
            Name = "Kick",
            Description = "Kick harder for each attack this turn",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 4,
                Hits = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };
        private static Card energyShield = new Card
        {
            Name = "Energy Shield",
            Description = "A shaped energy field blocks next 10 damage",
            EnemyEffect = new EnemyEffect()
            {

            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };

        internal static Card Kick { get => kick; }
        internal static Card SpinStrike { get => spinStrike; }
        internal static Card Flip { get => flip; }
        internal static Card Bolt { get => bolt; }
        internal static Card Whack { get => whack; }
        internal static Card Jab { get => jab; }
        internal static Card EnergyShield { get => energyShield; }
    }
}