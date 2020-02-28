using System.Collections.Generic;

namespace lord_of_death
{
    class CardData
    {
        public static List<Card> GetActiveDeck()
        {
            var deck = new List<Card> {
                 jab.Copy(), jab.Copy(), whack.Copy(), whack.Copy(), kick.Copy(),
                 kick.Copy(), bolt.Copy(), flip.Copy(), flip.Copy(), elderBoots.Copy(),
                 elderfascinator.Copy(), elderGauntlet.Copy(), buttonMushroom.Copy(), umbrellaMushroom.Copy(),
                 bundleMushroom.Copy() };
            return deck;
        }
        public static Card jab = new Card
        {
            Name = "Jab",
            Description = "jab staff with piercing blows",
            ImgName = "jab.png",
            ImgBack = "staff_back.png",
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
        public static Card whack = new Card
        {
            Name = "Whack",
            Description = "whack with staff twice",
            ImgName = "whack.png",
            ImgBack = "staff_back.png",
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

        public static Card bolt = new Card
        {
            Name = "Bolt",
            Description = "unleash raw magick from palm",
            ImgName = "bolt.png",
            ImgBack = "staff_back.png",
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
        public static Card flip = new Card
        {
            Name = "Flip",
            Description = "dodge next hit with style",
            ImgName = "flip.png",
            ImgBack = "acrobatics_back.png",
            EnemyEffect = new EnemyEffect()
            {
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Dodge = 1
            }
        };

        public static Card spinStrike = new Card
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
        public static Card kick = new Card
        {
            Name = "Kick",
            Description = "Kick harder for each attack this turn",
            ImgName = "kick.png",
            ImgBack = "acrobatics_back.png",
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
        public static Card energyShield = new Card
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

        public static Card elderBoots = new Card
        {
            Name = "Elder Bark Boots",
            Description = "These is boots they are",
            ImgBack = "armor_back.png",
            ImgName = "elder_bark_boots.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };


        public static Card elderGauntlet = new Card
        {
            Name = "Elder Bark Gauntlets",
            Description = "Punch SH*T",
            ImgBack = "armor_back.png",
            ImgName = "elder_bark_gauntlets.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };


        public static Card elderfascinator = new Card
        {
            Name = "Elder Bark Fascinator",
            Description = "Power be unto thee",
            ImgBack = "armor_back.png",
            ImgName = "elder_bark_fascinator.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };

        public static Card buttonMushroom = new Card
        {
            Name = "Fuzzy Button Mushroom",
            Description = "Eat and live",
            ImgBack = "consumable_back.png",
            ImgName = "fuzzy_button_mushroom.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };

        public static Card umbrellaMushroom = new Card
        {
            Name = "Glowing Umbrella Mushroom",
            Description = "Eat and shine",
            ImgBack = "consumable_back.png",
            ImgName = "glowing_umbrella_mushroom.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };

        public static Card bundleMushroom = new Card
        {
            Name = "Porous Bundle Mushroom",
            Description = "Eat and harden",
            ImgBack = "consumable_back.png",
            ImgName = "porous_bundle_mushroom.png",
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 2,
                Shield = 10
            }
        };



        // internal static Card Kick { get => kick; }
        // internal static Card SpinStrike { get => spinStrike; }
        // internal static Card Flip { get => flip; }
        // internal static Card Bolt { get => bolt; }
        // internal static Card Whack { get => whack; }
        // internal static Card Jab { get => jab; }
        // internal static Card EnergyShield { get => energyShield; }
    }
}