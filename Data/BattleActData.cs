namespace lord_of_death
{
    class BattleActData
    {
        public static BattleAct Bite = new BattleAct
        {
            Name = "Bite",
            Description = "teeth clamp down rapidly",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 2,
                Hits = 4
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };
        public static BattleAct Jump = new BattleAct
        {
            Name = "Jump",
            Description = "spring forward dodging once",//maybe momentum breaks stance
            EnemyEffect = new EnemyEffect()
            {
                Damage = 6,
                Hits = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Dodge = 1
            }
        };

        public static BattleAct Sting = new BattleAct
        {
            Name = "Sting",
            Description = "piercing prick of venom",//add status effect venom (mnstr lvl dmg per turn, stacks)
            EnemyEffect = new EnemyEffect()
            {
                Damage = 2,
                Hits = 1,
                Pierce = true,
                Venom = 3
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Scurry = new BattleAct
        {
            Name = "Scurry",
            Description = "quick movements dodge two hits",
            EnemyEffect = new EnemyEffect()
            {
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Dodge = 2
            }
        };

        public static BattleAct Grip = new BattleAct
        {
            Name = "Grip",
            Description = "a crush that snares on hit",//add status effect snare
            EnemyEffect = new EnemyEffect()
            {
                Damage = 2,
                Hits = 2
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Regenerate = new BattleAct
        {
            Name = "Regenerate",
            Description = "heal and harden tissue",

            EnemyEffect = new EnemyEffect()
            {
                Damage = 0,
                Hits = 0
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Heal = 4,
                Shield = 6
            }
        };
        public static BattleAct Rush = new BattleAct
        {
            Name = "Rush",
            Description = "so fast it cannot be dodged",
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

        //death is always present. the silent stalker that catches everyone
        public static BattleAct HeadBang = new BattleAct
        {
            Name = "Head Bang",
            Description = "showing no desire to keep his head in tact",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 2,
                Hits = 6
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Thrash = new BattleAct
        {
            Name = "Thrash",
            Description = "wild powerful swings",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 5,
                Hits = 3
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Claw = new BattleAct
        {
            Name = "Claw",
            Description = "Dig in with claws",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 7,
                Hits = 1,
                Bleed = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Crush = new BattleAct
        {
            Name = "Crush",
            Description = "Physically restrain and damage",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 5,
                Hits = 1,
                Crush = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };
        public static BattleAct BoneThrust = new BattleAct
        {
            Name = "Bone Thrust",
            Description = "A move meant to pierce organs",
            EnemyEffect = new EnemyEffect()
            {
                Damage = 14,
                Hits = 1,
                Pierce = true
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Reassemble = new BattleAct
        {
            Name = "Reassemble",
            Description = "Putting bones back in place",
            EnemyEffect = new EnemyEffect()
            {

            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Heal = 10
            }
        };

        public static BattleAct Sniff = new BattleAct
        {
            Name = "Sniff",
            Description = "fresh food encourages the soul.  +energy",
            EnemyEffect = new EnemyEffect()
            {

            },
            AllyEffect = new AllyEffect()
            {
                EnergyGained = 2,
                EnergyCost = 0
            }
        };

        public static BattleAct Growl = new BattleAct
        {
            Name = "Growl",
            Description = "A preditor steals the prey's will with a mighty growl",
            EnemyEffect = new EnemyEffect()
            {
                EnergyLoss = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyGained = 1,
                EnergyCost = 0
            }
        };

        public static BattleAct Womp = new BattleAct
        {
            Name = "Womp",
            Description = "A mighty swing from a heavy branch",
            EnemyEffect = new EnemyEffect()
            {
                Hits = 1,
                Damage = 9
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Entangle = new BattleAct
        {
            Name = "Entangle",
            Description = "snares creatures in a tangle of foilage, they cannot dodge",
            EnemyEffect = new EnemyEffect()
            {
                Snare = 1,
                Hits = 2,
                Damage = 0
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct PrickleAndScrape = new BattleAct
        {
            Name = "Prickle and Scrape",
            Description = "Motions evolved to rip away flesh",
            EnemyEffect = new EnemyEffect()
            {
                Hits = 3,
                Damage = 2,
                Bleed = 2
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
            }
        };

        public static BattleAct BloodSuck = new BattleAct
        {
            Name = "Blood Suck",
            Description = "attached and sucking for sustenance",
            EnemyEffect = new EnemyEffect()
            {
                Hits = 5,
                Damage = 1,
            },
            AllyEffect = new AllyEffect()
            {
                HealOnHit = 1,
                EnergyCost = 1
            }
        };

        public static BattleAct EnergySuck = new BattleAct
        {
            Name = "Energy Suck",
            Description = "attached and sucking for will",
            EnemyEffect = new EnemyEffect()
            {
                Hits = 3,
                Damage = 2,
                EnergyLoss = 1
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1
            }
        };

        public static BattleAct Burrow = new BattleAct
        {
            Name = "Burrow",
            Description = "quickly find shelter underground",
            EnemyEffect = new EnemyEffect()
            {
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                Shield = 6,
                Dodge = 1
            }
        };

        public static BattleAct Sweep = new BattleAct
        {
            Name = "Sweep",
            Description = "swing in a wide arc",
            EnemyEffect = new EnemyEffect()
            {
                Hits = 1,
                Damage = 12
            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
            }
        };

        public static BattleAct Adrenaline = new BattleAct
        {
            Name = "Adrenaline",
            Description = "Ride the excitement of combat",
            EnemyEffect = new EnemyEffect()
            {

            },
            AllyEffect = new AllyEffect()
            {
                EnergyCost = 1,
                EnergyGained = 1,
                Heal = 5,
                Shield = 5,
                Dodge = 1
            }
        };
    }
}