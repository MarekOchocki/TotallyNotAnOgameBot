using System.Collections.Generic;
using TotallyNotAnOgameBot.Data.TechnologyRequirements;
using TotallyNotAnOgameBot.Data.Buildings;
using TotallyNotAnOgameBot.Data.Defenses;
using TotallyNotAnOgameBot.Data.ResearchData;
using TotallyNotAnOgameBot.Data.FleetData;

namespace TotallyNotAnOgameBot.Calculations
{
    static class TechRequirementsCalculator
    {

        static private readonly Dictionary<Building.Type, TechRequirements> buildingRequirements;
        static private readonly Dictionary<Defense.Type, TechRequirements> defenseRequirements;
        static private readonly Dictionary<Research.Type, TechRequirements> researchRequirements;
        static private readonly Dictionary<Spaceships.Type, TechRequirements> spaceshipRequirements;

        static TechRequirementsCalculator()
        {
            buildingRequirements = new Dictionary<Building.Type, TechRequirements>
            {
                {Building.Type.MetalMine, new TechRequirements() },
                {Building.Type.CrystalMine, new TechRequirements() },
                {Building.Type.DeuteriumSynthesizer, new TechRequirements() },
                {Building.Type.SolarPlant, new TechRequirements() },
                {Building.Type.MetalStorage, new TechRequirements() },
                {Building.Type.CrystalStorage, new TechRequirements() },
                {Building.Type.DeuteriumTank, new TechRequirements() },
                {Building.Type.RoboticsFactory, new TechRequirements() },
                {Building.Type.ResarchLab, new TechRequirements() },
                {Building.Type.AllianceDepot, new TechRequirements() },
                {Building.Type.FusionReactor, new TechRequirements()
                    .addRequirement(Building.Type.DeuteriumSynthesizer, 5)
                    .addRequirement(Research.Type.EnergyTechnology, 3)},
                {Building.Type.Shipyard, new TechRequirements()
                    .addRequirement(Building.Type.RoboticsFactory, 2)},
                {Building.Type.MissileSilo, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 1)},
                {Building.Type.NaniteFactory, new TechRequirements()
                    .addRequirement(Building.Type.RoboticsFactory, 10)
                    .addRequirement(Research.Type.ComputerTechnology, 10)},
                {Building.Type.Terraformer, new TechRequirements()
                    .addRequirement(Building.Type.NaniteFactory, 1)
                    .addRequirement(Research.Type.EnergyTechnology, 12)},
                {Building.Type.SpaceDock, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 2)},
                {Building.Type.LunarBase, new TechRequirements()},
                {Building.Type.SensorPhalanx, new TechRequirements()
                    .addRequirement(Building.Type.LunarBase, 1)},
                {Building.Type.JumpGate, new TechRequirements()
                    .addRequirement(Building.Type.LunarBase, 1)
                    .addRequirement(Research.Type.HyperspaceTechnology, 7)},
                {Building.Type.MoonRoboticsFactory, new TechRequirements() },
                {Building.Type.MoonShipyard, new TechRequirements()
                    .addRequirement(Building.Type.MoonRoboticsFactory, 2)},
                {Building.Type.MoonMetalStorage, new TechRequirements() },
                {Building.Type.MoonCrystalStorage, new TechRequirements() },
                {Building.Type.MoonDeuteriumTank, new TechRequirements() },
                {Building.Type.MoonAllianceDepot, new TechRequirements() }

            };

            defenseRequirements = new Dictionary<Defense.Type, TechRequirements>
            {
                {Defense.Type.RocletLauncher, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 1)},
                {Defense.Type.LightLaser, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 2)
                    .addRequirement(Research.Type.LaserTechnology, 3)},
                {Defense.Type.HeavyLaser, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 4)
                    .addRequirement(Research.Type.EnergyTechnology, 3)
                    .addRequirement(Research.Type.LaserTechnology, 6)},
                {Defense.Type.GaussCannon, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 6)
                    .addRequirement(Research.Type.WeaponsTechnology, 3)
                    .addRequirement(Research.Type.EnergyTechnology, 6)
                    .addRequirement(Research.Type.ShieldingTechnology, 1)},
                {Defense.Type.IonCannon, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 4)
                    .addRequirement(Research.Type.IonTechnology, 4)},
                {Defense.Type.PlasmaTurret, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 8)
                    .addRequirement(Research.Type.PlasmaTechnology, 7)},
                {Defense.Type.SmallShieldDome, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 1)
                    .addRequirement(Research.Type.ShieldingTechnology, 2)},
                {Defense.Type.LargeShieldDome, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 6)
                    .addRequirement(Research.Type.ShieldingTechnology, 6)},
                {Defense.Type.AntiBalisticMissiles, new TechRequirements()
                    .addRequirement(Building.Type.MissileSilo, 2)},
                {Defense.Type.InterplanetaryMissiles, new TechRequirements()
                    .addRequirement(Building.Type.MissileSilo, 4)
                    .addRequirement(Research.Type.ImpulseDrive, 1)}
            };

            researchRequirements = new Dictionary<Research.Type, TechRequirements>
            {
                {Research.Type.EnergyTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 1)},
                {Research.Type.LaserTechnology, new TechRequirements()
                    .addRequirement(Research.Type.EnergyTechnology, 2)},
                {Research.Type.IonTechnology, new TechRequirements()
                    .addRequirement(Research.Type.LaserTechnology, 5)
                    .addRequirement(Building.Type.ResarchLab, 4)
                    .addRequirement(Research.Type.EnergyTechnology, 4)},
                {Research.Type.HyperspaceTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 7)
                    .addRequirement(Research.Type.ShieldingTechnology, 5)
                    .addRequirement(Research.Type.EnergyTechnology, 5)},
                {Research.Type.PlasmaTechnology, new TechRequirements()
                    .addRequirement(Research.Type.LaserTechnology, 10)
                    .addRequirement(Research.Type.IonTechnology, 5)
                    .addRequirement(Research.Type.EnergyTechnology, 8)},
                {Research.Type.CombustionDrive, new TechRequirements()
                    .addRequirement(Research.Type.EnergyTechnology, 1)},
                {Research.Type.ImpulseDrive, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 2)
                    .addRequirement(Research.Type.EnergyTechnology, 1)},
                {Research.Type.HyperspaceDrive, new TechRequirements()
                    .addRequirement(Research.Type.HyperspaceTechnology, 3)},
                {Research.Type.EspionageTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 3)},
                {Research.Type.ComputerTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 1)},
                {Research.Type.Astrophysics, new TechRequirements()
                    .addRequirement(Research.Type.ImpulseDrive, 3)
                    .addRequirement(Research.Type.EspionageTechnology, 4)},
                {Research.Type.IntergalacticResearchNetwork, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 10)
                    .addRequirement(Research.Type.ComputerTechnology, 8)
                    .addRequirement(Research.Type.HyperspaceTechnology, 8)},
                {Research.Type.GravitonTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 12)},
                {Research.Type.WeaponsTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 4)},
                {Research.Type.ShieldingTechnology, new TechRequirements()
                    .addRequirement(Research.Type.EnergyTechnology, 3)
                    .addRequirement(Building.Type.ResarchLab, 6)},
                {Research.Type.ArmourTechnology, new TechRequirements()
                    .addRequirement(Building.Type.ResarchLab, 2)},
            };

            spaceshipRequirements = new Dictionary<Spaceships.Type, TechRequirements>
            {
                {Spaceships.Type.LightFighter, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 1)
                    .addRequirement(Research.Type.CombustionDrive, 1)},
                {Spaceships.Type.HeavyFighter, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 3)
                    .addRequirement(Research.Type.ArmourTechnology, 2)
                    .addRequirement(Research.Type.ImpulseDrive, 2)},
                {Spaceships.Type.Crusier, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 5)
                    .addRequirement(Research.Type.ImpulseDrive, 4)
                    .addRequirement(Research.Type.IonTechnology, 2)},
                {Spaceships.Type.Battleship, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 7)
                    .addRequirement(Research.Type.HyperspaceDrive, 4)},
                {Spaceships.Type.Battlecrusier, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 8)
                    .addRequirement(Research.Type.LaserTechnology, 12)
                    .addRequirement(Research.Type.HyperspaceDrive, 5)
                    .addRequirement(Research.Type.HyperspaceTechnology, 5)},
                {Spaceships.Type.Bomber, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 8)
                    .addRequirement(Research.Type.PlasmaTechnology, 5)
                    .addRequirement(Research.Type.ImpulseDrive, 6)},
                {Spaceships.Type.Destroyer, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 9)
                    .addRequirement(Research.Type.HyperspaceDrive, 6)
                    .addRequirement(Research.Type.HyperspaceTechnology, 5)},
                {Spaceships.Type.Deathstar, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 12)
                    .addRequirement(Research.Type.GravitonTechnology, 1)
                    .addRequirement(Research.Type.HyperspaceDrive, 7)
                    .addRequirement(Research.Type.HyperspaceTechnology, 6)},
                {Spaceships.Type.SmallCargo, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 2)
                    .addRequirement(Research.Type.CombustionDrive, 2)},
                {Spaceships.Type.LargeCargo, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 4)
                    .addRequirement(Research.Type.CombustionDrive, 6)},
                {Spaceships.Type.ColonyShip, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 4)
                    .addRequirement(Research.Type.ImpulseDrive, 3)},
                {Spaceships.Type.Recycler, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 4)
                    .addRequirement(Research.Type.ShieldingTechnology, 2)
                    .addRequirement(Research.Type.CombustionDrive, 6)},
                {Spaceships.Type.EspionageProbe, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 3)
                    .addRequirement(Research.Type.CombustionDrive, 3)
                    .addRequirement(Research.Type.EspionageTechnology, 2)},
                {Spaceships.Type.SolarSatelite, new TechRequirements()
                    .addRequirement(Building.Type.Shipyard, 1)},
            };
        }

        static public TechRequirements getResearchRequirements(Research.Type type)
        {
            researchRequirements.TryGetValue(type, out TechRequirements techRequirements);
            return techRequirements;
        }

        static public TechRequirements getDefenseRequirements(Defense.Type type)
        {
            defenseRequirements.TryGetValue(type, out TechRequirements techRequirements);
            return techRequirements;
        }

        static public TechRequirements getBuildingRequirements(Building.Type type)
        {
            buildingRequirements.TryGetValue(type, out TechRequirements techRequirements);
            return techRequirements;
        }

        static public TechRequirements getSpaceshipRequirements(Spaceships.Type type)
        {
            spaceshipRequirements.TryGetValue(type, out TechRequirements techRequirements);
            return techRequirements;
        }
    }
}
