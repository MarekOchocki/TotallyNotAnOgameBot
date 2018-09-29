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
    static class ConstCalculator
    {
        static private readonly Dictionary<Building.Type, Resources> BuildingsDic
        = new Dictionary<Building.Type, Resources>
        {
            {Building.Type.MetalMine, new Resources(60, 15, 0) }, 
            {Building.Type.CrystalMine, new Resources(48, 24, 0) }, 
            {Building.Type.DeuteriumSynthesizer, new Resources(225, 75, 0) },
            {Building.Type.SolarPlant, new Resources(75, 30, 0) },
            {Building.Type.FusionReactor, new Resources(900, 360, 180) },
            {Building.Type.SolarSatelite, new Resources(0, 2000, 500) },
            {Building.Type.MetalStorge, new Resources(1000, 0, 0) },
            {Building.Type.CrystalStorge, new Resources(1000, 500, 0) },
            {Building.Type.DeuteriumTank, new Resources(1000, 1000, 0) },
            {Building.Type.RoboticsFactory, new Resources(400, 120, 200) },
            {Building.Type.Shipyard, new Resources(400, 200, 100) },
            {Building.Type.ResarchLab, new Resources(200, 400, 200) },
            {Building.Type.AllianceDepot, new Resources(20000, 40000, 0) },
            {Building.Type.MissileSilo, new Resources(20000, 20000, 1000) },
            {Building.Type.NaniteFactory, new Resources(1000000, 500000, 100000) },
            {Building.Type.Terraformer, new Resources(0, 50000, 100000, 1000) },
            {Building.Type.SpaceDock, new Resources(200, 0, 50) }, 
            {Building.Type.LunarBase, new Resources(20000, 40000,20000) },
            {Building.Type.SensorPhalanx, new Resources(20000, 40000,20000) },
            {Building.Type.JumpGate, new Resources(2000000, 4000000,2000000) },
        };

        static private readonly Dictionary<Defense.Type, Resources> DefencesDic
        = new Dictionary<Defense.Type, Resources>
        {
            {Defense.Type.RocletLauncher, new Resources(2000, 0, 0) },
            {Defense.Type.LightLaser, new Resources(1500, 500, 0) },
            {Defense.Type.HeavyLaser, new Resources(6000, 2000, 0) },
            {Defense.Type.GaussCannon, new Resources(20000, 15000, 2000) },
            {Defense.Type.IonCannon, new Resources(2000, 6000, 0) },
            {Defense.Type.PlasmaTurret, new Resources(50000, 50000, 30000) },
            {Defense.Type.SmallShieldDome, new Resources(10000, 10000, 0) },
            {Defense.Type.LargeShieldDome, new Resources(50000, 50000, 0) },
            {Defense.Type.AntiBalisticMissiles, new Resources(8000, 0, 2000) },
            {Defense.Type.InterplanetaryMissiles, new Resources(12500, 2500, 10000) }
        };

        static private readonly Dictionary<Resarch.Type, Resources> ResarchDic
        = new Dictionary<Resarch.Type, Resources>
        {
            {Resarch.Type.EnergyTechnology, new Resources( 0, 800, 400) },
            {Resarch.Type.LaserTechnology, new Resources( 200, 100, 0) },
            {Resarch.Type.IonTechnology, new Resources( 1000, 300, 100) },
            {Resarch.Type.HyperspaceTechnology, new Resources( 0, 4000, 2000) },
            {Resarch.Type.PlasmaTechnology, new Resources( 2000, 4000, 1000) },
            {Resarch.Type.EspionageTechnology, new Resources( 200, 1000, 200) },
            {Resarch.Type.ComputerTechnology, new Resources( 0, 400, 600) },
            {Resarch.Type.Astrophysics, new Resources( 4000, 8000, 4000) },
            {Resarch.Type.IntergalacticResearchNetwork, new Resources( 240000, 400000, 160000) },
            {Resarch.Type.GravitonTechnology, new Resources( 0, 0, 0, 100000) },
            {Resarch.Type.WeaponsTechnology, new Resources( 800, 200, 0) },
            {Resarch.Type.ShieldingTechnology, new Resources( 200, 600, 0) },
            {Resarch.Type.ArmourTechnology, new Resources( 1000, 0, 0) },
            {Resarch.Type.CombustionDrive, new Resources( 400, 0, 600) },
            {Resarch.Type.ImpulseDrive, new Resources( 2000, 4000, 600) },
            {Resarch.Type.HyperspaceDrive, new Resources( 10000, 20000, 6000) },
        };

        static private readonly Dictionary<Spaceships.Type, Resources> SpaceshipDic
            = new Dictionary<Spaceships.Type, Resources>
            {
                {Spaceships.Type.LightFighter, new Resources(3000, 1000, 0) },
                {Spaceships.Type.HeavyFighter, new Resources(6000, 4000, 0) },
                {Spaceships.Type.Crusier, new Resources(20000, 7000, 2000) },
                {Spaceships.Type.Battleship, new Resources(20000, 7000, 2000) },
                {Spaceships.Type.Battlecrusier, new Resources(30000, 40000, 15000) },
                {Spaceships.Type.Bomber, new Resources(50000, 25000, 15000) },
                {Spaceships.Type.Destroyer, new Resources(60000, 50000, 15000) },
                {Spaceships.Type.Deathstar, new Resources(5000000, 4000000, 1000000) },
                {Spaceships.Type.SmallCargo, new Resources(2000, 2000, 0) },
                {Spaceships.Type.LargeCargo, new Resources(6000, 6000, 0) },
                {Spaceships.Type.ColonyShip, new Resources(10000, 20000, 10000) },
                {Spaceships.Type.Recykler, new Resources(10000, 6000, 2000) },
                {Spaceships.Type.EspionageProbe, new Resources(0, 1000, 0) },
                {Spaceships.Type.SolarSatelite, new Resources(0, 5000, 500) },
            };
    }
}
