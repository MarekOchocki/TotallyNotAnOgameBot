using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Resource;
using TotallyNotAnOgameBot.Data.Buildings;
using TotallyNotAnOgameBot.Data.Resarch;
using TotallyNotAnOgameBot.Data.Defenses;
using TotallyNotAnOgameBot.Data.FleetData;

namespace TotallyNotAnOgameBot.Calculations
{
    class CostCalculator
    {
        static private readonly Dictionary<Building.Type, Cost> buildings;
        static private readonly Dictionary<Defense.Type, Cost> defenses;
        static private readonly Dictionary<Resarch.Type, Cost> resarch;
        static private readonly Dictionary<Spaceships.Type, Cost> spaceship;

        static CostCalculator()
        {
            buildings = new Dictionary<Building.Type, Cost>
            {
                {Building.Type.MetalMine, new Cost(60, 15, 0) },
                {Building.Type.CrystalMine, new Cost(48, 24, 0) },
                {Building.Type.DeuteriumSynthesizer, new Cost(225, 75, 0) },
                {Building.Type.SolarPlant, new Cost(75, 30, 0) },
                {Building.Type.FusionReactor, new Cost(900, 360, 180) },
                {Building.Type.SolarSatelite, new Cost(0, 2000, 500) },
                {Building.Type.MetalStorge, new Cost(1000, 0, 0) },
                {Building.Type.CrystalStorge, new Cost(1000, 500, 0) },
                {Building.Type.DeuteriumTank, new Cost(1000, 1000, 0) },
                {Building.Type.RoboticsFactory, new Cost(400, 120, 200) },
                {Building.Type.Shipyard, new Cost(400, 200, 100) },
                {Building.Type.ResarchLab, new Cost(200, 400, 200) },
                {Building.Type.AllianceDepot, new Cost(20000, 40000, 0) },
                {Building.Type.MissileSilo, new Cost(20000, 20000, 1000) },
                {Building.Type.NaniteFactory, new Cost(1000000, 500000, 100000) },
                {Building.Type.Terraformer, new Cost(0, 50000, 100000, 1000) },
                {Building.Type.SpaceDock, new Cost(200, 0, 50, 50) },
                {Building.Type.LunarBase, new Cost(20000, 40000,20000) },
                {Building.Type.SensorPhalanx, new Cost(20000, 40000,20000) },
                {Building.Type.JumpGate, new Cost(2000000, 4000000,2000000) },
            };

            defenses = new Dictionary<Defense.Type, Cost>
            {
                {Defense.Type.RocletLauncher, new Cost(2000, 0, 0) },
                {Defense.Type.LightLaser, new Cost(1500, 500, 0) },
                {Defense.Type.HeavyLaser, new Cost(6000, 2000, 0) },
                {Defense.Type.GaussCannon, new Cost(20000, 15000, 2000) },
                {Defense.Type.IonCannon, new Cost(2000, 6000, 0) },
                {Defense.Type.PlasmaTurret, new Cost(50000, 50000, 30000) },
                {Defense.Type.SmallShieldDome, new Cost(10000, 10000, 0) },
                {Defense.Type.LargeShieldDome, new Cost(50000, 50000, 0) },
                {Defense.Type.AntiBalisticMissiles, new Cost(8000, 0, 2000) },
                {Defense.Type.InterplanetaryMissiles, new Cost(12500, 2500, 10000) }
            };

            resarch = new Dictionary<Resarch.Type, Cost>
            {
                {Resarch.Type.EnergyTechnology, new Cost( 0, 800, 400) },
                {Resarch.Type.LaserTechnology, new Cost( 200, 100, 0) },
                {Resarch.Type.IonTechnology, new Cost( 1000, 300, 100) },
                {Resarch.Type.HyperspaceTechnology, new Cost( 0, 4000, 2000) },
                {Resarch.Type.PlasmaTechnology, new Cost( 2000, 4000, 1000) },
                {Resarch.Type.EspionageTechnology, new Cost( 200, 1000, 200) },
                {Resarch.Type.ComputerTechnology, new Cost( 0, 400, 600) },
                {Resarch.Type.Astrophysics, new Cost( 4000, 8000, 4000) },
                {Resarch.Type.IntergalacticResearchNetwork, new Cost( 240000, 400000, 160000) },
                {Resarch.Type.GravitonTechnology, new Cost( 0, 0, 0, 100000) },
                {Resarch.Type.WeaponsTechnology, new Cost( 800, 200, 0) },
                {Resarch.Type.ShieldingTechnology, new Cost( 200, 600, 0) },
                {Resarch.Type.ArmourTechnology, new Cost( 1000, 0, 0) },
                {Resarch.Type.CombustionDrive, new Cost( 400, 0, 600) },
                {Resarch.Type.ImpulseDrive, new Cost( 2000, 4000, 600) },
                {Resarch.Type.HyperspaceDrive, new Cost( 10000, 20000, 6000) },
            };

            spaceship = new Dictionary<Spaceships.Type, Cost>
            {
                {Spaceships.Type.LightFighter, new Cost(3000, 1000, 0) },
                {Spaceships.Type.HeavyFighter, new Cost(6000, 4000, 0) },
                {Spaceships.Type.Crusier, new Cost(20000, 7000, 2000) },
                {Spaceships.Type.Battleship, new Cost(20000, 7000, 2000) },
                {Spaceships.Type.Battlecrusier, new Cost(30000, 40000, 15000) },
                {Spaceships.Type.Bomber, new Cost(50000, 25000, 15000) },
                {Spaceships.Type.Destroyer, new Cost(60000, 50000, 15000) },
                {Spaceships.Type.Deathstar, new Cost(5000000, 4000000, 1000000) },
                {Spaceships.Type.SmallCargo, new Cost(2000, 2000, 0) },
                {Spaceships.Type.LargeCargo, new Cost(6000, 6000, 0) },
                {Spaceships.Type.ColonyShip, new Cost(10000, 20000, 10000) },
                {Spaceships.Type.Recykler, new Cost(10000, 6000, 2000) },
                {Spaceships.Type.EspionageProbe, new Cost(0, 1000, 0) },
                {Spaceships.Type.SolarSatelite, new Cost(0, 5000, 500) },
            };
        }

        static private void Multiplication(ref Cost cost, double multipler, int level)
        {
            double metalValue = cost.resources.getMetalQuantity();
            metalValue = metalValue * Math.Pow(multipler, level);
            double crystalValue = cost.resources.getCrystalQuantity();
            crystalValue = Math.Pow(multipler, level) * crystalValue;
            double deuterValue = cost.resources.getDeuterQuantity();
            deuterValue = Math.Pow(multipler, level) * deuterValue;
            double energyValue = cost.energy.getValue();
            energyValue = Math.Pow(multipler, level) * energyValue;

            cost.resources.setResources((long)metalValue, (long)crystalValue, (long)deuterValue);
            cost.energy.setValue((long)energyValue);
        }

        static private void Multiplication(ref Cost cost, int quantity)
        {
            double metalValue = cost.resources.getMetalQuantity() * quantity;
            double crystalValue = cost.resources.getCrystalQuantity() * quantity;
            double deuterValue = cost.resources.getDeuterQuantity() * quantity;

            cost.resources.setResources((long)metalValue, (long)crystalValue, (long)deuterValue);
        }

        static public Cost getBuildingCost(Building.Type type, int level)
        {
            buildings.TryGetValue(type, out Cost cost);
            if((type == Building.Type.MetalMine) || 
                (type == Building.Type.DeuteriumSynthesizer) || 
                (type == Building.Type.SolarPlant))
            {
                    Multiplication(ref cost, 1.5, level);

            }else if(type == Building.Type.CrystalMine)
            {
                    Multiplication(ref cost, 1.6, level);

            }else if(type == Building.Type.FusionReactor)
            {
                    Multiplication(ref cost, 1.8, level);
            }else
            {
                    Multiplication(ref cost, 2, level);
            }
            return cost;
        }

        static public Cost getDefenseCost(Defense.Type type, int quantity)
        {
            defenses.TryGetValue(type, out Cost cost);
                Multiplication(ref cost, quantity);
            return cost;
        }

        static public Cost getResarchCost(Resarch.Type type, int level)
        {
            resarch.TryGetValue(type, out Cost cost);
            if (type == Resarch.Type.GravitonTechnology)
            {
                Multiplication(ref cost, 3, level);
            }else
            {
                Multiplication(ref cost, 2, level);
            }
            return cost;
        }

        static public Cost getSpaceshipsCost(Spaceships.Type type, int quantity)
        {
            spaceship.TryGetValue(type, out Cost cost);
                Multiplication(ref cost, quantity);
            return cost;
        }
    }
}
