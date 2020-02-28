using System.Collections.Generic;

namespace lord_of_death
{
    class CombatantData
    {
        public static Combatant SummonPlayer(int level = 1)
        {
            return new Combatant
            {
                Name = "Gretchin",
                MaxHealth = 60,
                Health = 60,
                MaxEnergy = 4,
                Energy = 4,
                ImgName = "player.gif"
            };
        }

        public static Combatant SummonSpider(int level = 1)
        {
            return new Combatant
            {
                Name = "🕷 Arachnid",
                MaxHealth = 30,
                Health = 30,
                MaxEnergy = 2,
                Energy = 4,
                Level = level,
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Jump,
                    BattleActData.Sting,
                    BattleActData.Bite,
                    BattleActData.Scurry
                    }
                }
            };
        }

        public static Combatant SummonCentipede(int level = 1)
        {
            return new Combatant
            {
                Name = "🐛 Centipede",
                MaxHealth = 40,
                Health = 40,
                MaxEnergy = 2,
                Energy = 4,
                Level = level,
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Rush,
                    BattleActData.Grip,
                    BattleActData.Bite,
                    BattleActData.Regenerate
                    }

                }
            };
        }
        //about skeletons - skeletons are comedians with no respect for life
        //their jokes provoke emotional reactions of every sort, and the punchline is always death
        //when they know they are outmatched they play dead (they are always playing)
        //as their numbers increase they become funnier (so they think)
        //they cannot speak, but they can laugh, creak, and chatter.
        // they enjoy slapstick, exposing bones, 
        //mock sexuality, ancient, but hip
        //puns: knee slapper, punchline, slapstick, funny bone
        public static Combatant SummonSkele(int level = 1)
        {
            return new Combatant
            {
                Name = "💀 Skel",
                MaxHealth = 30,
                Health = 30,
                MaxEnergy = 2,
                Energy = 4,
                Level = level,
                ImgName = "skele.gif",
                AllyStatus = new AllyStatus()
                {
                    Shield = 10
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.BoneThrust,
                    BattleActData.Thrash,
                    BattleActData.HeadBang,
                    BattleActData.Regenerate
                    }
                }
            };
        }

        public static Combatant SummonScrawnyBeastman(int level = 1)
        {
            return new Combatant
            {
                Name = "Scrawny Beastman",
                MaxHealth = 80,
                Health = 80,
                MaxEnergy = 2,
                EnergyGainPerTurn = 0,
                Energy = 0,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Sniff,
                    BattleActData.Claw,
                    BattleActData.Growl,
                    BattleActData.Bite,
                    BattleActData.Regenerate
                }
                }
            };
        }

        public static Combatant SummonBeastman(int level = 1)
        {
            return new Combatant
            {
                Name = "Beastman",
                MaxHealth = 70,
                Health = 70,
                MaxEnergy = 2,
                Energy = 1,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                    Shield = 10
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Growl,
                    BattleActData.Sweep,
                    BattleActData.BoneThrust,
                    BattleActData.Thrash,
                    BattleActData.Bite,
                    BattleActData.Regenerate,
                    BattleActData.Growl,
                    BattleActData.Adrenaline,
                    BattleActData.Rush,
                    BattleActData.BoneThrust
                }
                }
            };
        }

        public static Combatant SummonTreent(int level = 1)
        {
            return new Combatant
            {
                Name = "Treent",
                MaxHealth = 50,
                Health = 50,
                MaxEnergy = 2,
                Energy = 2,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Womp,
                    BattleActData.Entangle,
                    BattleActData.PrickleAndScrape,
                    BattleActData.Regenerate
                }
                }
            };
        }

        public static Combatant SummonBloodworm(int level = 1)
        {
            return new Combatant
            {
                Name = "Bloodworm",
                MaxHealth = 20,
                Health = 20,
                MaxEnergy = 2,
                Energy = 2,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Sniff,
                    BattleActData.BloodSuck,
                    BattleActData.Burrow,
                }
                }
            };
        }

        public static Combatant SummonWoodworm(int level = 1)
        {
            return new Combatant
            {
                Name = "Woodworm",
                MaxHealth = 20,
                Health = 20,
                MaxEnergy = 2,
                Energy = 2,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Sniff,
                    BattleActData.EnergySuck,
                    BattleActData.Burrow,
                    BattleActData.Regenerate
                }
                }
            };
        }

        public static Combatant SummonRiverworm(int level = 1)
        {
            return new Combatant
            {
                Name = "Riverworm",
                MaxHealth = 20,
                Health = 20,
                MaxEnergy = 2,
                Energy = 2,
                Level = level,
                AllyStatus = new AllyStatus()
                {
                },
                BattleCircuit = new BattleCircuit
                {
                    AggroLoop = new List<BattleAct>{
                    BattleActData.Sniff,
                    BattleActData.BloodSuck,
                    BattleActData.EnergySuck,
                    BattleActData.Regenerate
                }
                }
            };
        }
    }
}