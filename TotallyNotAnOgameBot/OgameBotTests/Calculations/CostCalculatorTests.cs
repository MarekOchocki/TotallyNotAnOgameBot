using System;
using NUnit.Framework;
using TotallyNotAnOgameBot.Calculations;
using TotallyNotAnOgameBot.Data.Research;
using TotallyNotAnOgameBot.Data.Buildings;
using TotallyNotAnOgameBot.Data.Defenses;
using TotallyNotAnOgameBot.Data.FleetData;

namespace OgameBotTests.Calculations
{
    [TestFixture]
    public class CostCalculatorTests
    {
        [Test]
        public void GetResearchCost_LevelBelowZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getResarchCost(Research.Type.ArmourTechnology, -1);

            Assert.Throws<Exception>(calculate);
        }

        [Test]
        public void GetResearchCost_LevelZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getResarchCost(Research.Type.ArmourTechnology, 0);

            Assert.Throws<Exception>(calculate);
        }
        
        [TestCase(Research.Type.WeaponsTechnology, 4, 6400, 1600, 0, 0)]
        [TestCase(Research.Type.ShieldingTechnology, 4, 1600, 4800, 0, 0)]
        [TestCase(Research.Type.PlasmaTechnology, 4, 16000, 32000, 8000, 0)]
        [TestCase(Research.Type.LaserTechnology, 4, 1600, 800, 0, 0)]
        [TestCase(Research.Type.IonTechnology, 4, 8000, 2400, 800, 0)]
        [TestCase(Research.Type.IntergalacticResearchNetwork, 4, 1920000, 3200000, 1280000, 0)]
        [TestCase(Research.Type.ImpulseDrive, 4, 16000, 32000, 4800, 0)]
        [TestCase(Research.Type.HyperspaceTechnology, 4, 0, 32000, 16000, 0)]
        [TestCase(Research.Type.HyperspaceDrive, 4, 80000, 160000, 48000, 0)]
        [TestCase(Research.Type.GravitonTechnology, 2, 0, 0, 0, 900000)]
        [TestCase(Research.Type.EspionageTechnology, 4, 1600, 8000, 1600, 0)]
        [TestCase(Research.Type.EnergyTechnology, 4, 0, 6400, 3200, 0)]
        [TestCase(Research.Type.ComputerTechnology, 4, 0, 3200, 4800, 0)]
        [TestCase(Research.Type.CombustionDrive, 4, 3200, 0, 4800, 0)]
        [TestCase(Research.Type.Astrophysics, 4, 21400, 42900, 21400, 0)]
        [TestCase(Research.Type.ArmourTechnology, 4, 8000, 0, 0, 0)]
        public void GetResearchCost_CorrectArguments_OK(Research.Type type, int level, long metal, long crystal, long deuter, long energy)
        {
            var expected = new Cost(metal, crystal, deuter, energy);

            var result = CostCalculator.getResarchCost(type, level);

            Assert.AreEqual(expected.resources.getMetalQuantity(), result.resources.getMetalQuantity());
            Assert.AreEqual(expected.resources.getCrystalQuantity(), result.resources.getCrystalQuantity());
            Assert.AreEqual(expected.resources.getDeuterQuantity(), result.resources.getDeuterQuantity());
            Assert.AreEqual(expected.energy.getValue(), result.energy.getValue());
        }

        [Test]
        public void getBuildingCost_LevelBelowZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getBuildingCost(Building.Type.AllianceDepot, -1);

            Assert.Throws<Exception>(calculate);
        }

        [Test]
        public void getBuildingCost_LevelZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getBuildingCost(Building.Type.AllianceDepot, 0);

            Assert.Throws<Exception>(calculate);
        }


        [TestCase(Building.Type.AllianceDepot, 4, 160000, 320000, 0, 0)]
        [TestCase(Building.Type.CrystalMine, 23, 1485528, 742764, 0, 0)]
        [TestCase(Building.Type.CrystalStorge, 5, 16000, 8000, 0, 0)]
        [TestCase(Building.Type.DeuteriumSynthesizer, 23, 1683411, 561137, 0, 0)]
        [TestCase(Building.Type.DeuteriumTank, 5, 16000, 16000, 0, 0)]
        [TestCase(Building.Type.FusionReactor, 7, 30611, 12224, 6122, 0)]
        [TestCase(Building.Type.JumpGate, 3, 8000000, 16000000, 8000000, 0)]
        [TestCase(Building.Type.LunarBase, 5, 320000, 640000, 320000, 0)]
        [TestCase(Building.Type.MetalMine, 23, 448909, 112227, 0, 0)]
        [TestCase(Building.Type.MetalStorge, 5, 16000, 112227, 0, 0)]
        [TestCase(Building.Type.MissileSilo, 5, 32000, 320000, 16000, 0)]
        [TestCase(Building.Type.NaniteFactory, 4, 8000000, 4000000, 800000, 0)]
        [TestCase(Building.Type.ResarchLab, 5, 3200, 6400, 3200, 0)]
        [TestCase(Building.Type.RoboticsFactory, 5, 6400, 1920, 3200, 0)]
        [TestCase(Building.Type.SensorPhalanx, 5, 320000, 640000, 320000, 0)]
        [TestCase(Building.Type.Shipyard, 5, 6400, 3200, 1600, 0)]
        [TestCase(Building.Type.SolarPlant, 23, 561137, 224454, 0, 0)]
        [TestCase(Building.Type.SpaceDock, 5, 125000, 0, 31250, 31250)]
        public void getBuildingCost_CorrectArguments_OK(Building.Type type, int level, long metal, long crystal, long deuter, long energy)
        {
            var expected = new Cost(metal, crystal, deuter, energy);

            var result = CostCalculator.getBuildingCost(type, level);

            Assert.AreEqual(expected.resources.getMetalQuantity(), result.resources.getMetalQuantity());
            Assert.AreEqual(expected.resources.getCrystalQuantity(), result.resources.getCrystalQuantity());
            Assert.AreEqual(expected.resources.getDeuterQuantity(), result.resources.getDeuterQuantity());
            Assert.AreEqual(expected.energy.getValue(), result.energy.getValue());
        }

        [Test]
        public void getSpaceshipsCost_LevelBelowZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getSpaceshipsCost(Spaceships.Type.Deathstar, -1);

            Assert.Throws<Exception>(calculate);
        }

        [Test]
        public void getSpaceshipsCost_LevelZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getSpaceshipsCost(Spaceships.Type.Deathstar, 0);

            Assert.Throws<Exception>(calculate);
        }

        [TestCase(Spaceships.Type.SmallCargo, 5, 10000, 10000, 0, 0)]
        [TestCase(Spaceships.Type.LargeCargo, 5, 30000, 30000, 0, 0)]
        [TestCase(Spaceships.Type.LightFighter, 5, 15000, 5000, 0, 0)]
        [TestCase(Spaceships.Type.HeavyFighter, 5, 30000, 20000, 0, 0)]
        [TestCase(Spaceships.Type.Crusier, 5, 100000, 35000, 10000, 0)]
        [TestCase(Spaceships.Type.Battleship, 5, 225000, 75000, 0, 0)]
        [TestCase(Spaceships.Type.ColonyShip, 5, 50000, 100000, 50000, 0)]
        [TestCase(Spaceships.Type.Recykler, 5, 50000, 30000, 10000, 0)]
        [TestCase(Spaceships.Type.EspionageProbe, 5, 0, 5000, 0, 0)]
        [TestCase(Spaceships.Type.Bomber, 5, 250000, 125000, 75000, 0)]
        [TestCase(Spaceships.Type.SolarSatelite, 5, 0, 10000, 2500, 0)]
        [TestCase(Spaceships.Type.Destroyer, 5, 300000, 250000, 75000, 0)]
        [TestCase(Spaceships.Type.Deathstar, 5, 25000000, 20000000, 5000000, 0)]
        [TestCase(Spaceships.Type.Battlecrusier, 5, 150000, 200000, 75000, 0)]
        public void getSpaceshipsCost_CorrectArguments_OK(Spaceships.Type type, int quantity, long metal, long crystal, long deuter, long energy)
        {
            var expected = new Cost(metal, crystal, deuter, energy);

            var result = CostCalculator.getSpaceshipsCost(type, quantity);

            Assert.AreEqual(expected.resources.getMetalQuantity(), result.resources.getMetalQuantity());
            Assert.AreEqual(expected.resources.getCrystalQuantity(), result.resources.getCrystalQuantity());
            Assert.AreEqual(expected.resources.getDeuterQuantity(), result.resources.getDeuterQuantity());
            Assert.AreEqual(expected.energy.getValue(), result.energy.getValue());
        }

        [Test]
        public void getDefenseCost_LevelBelowZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getDefenseCost(Defense.Type.AntiBalisticMissiles, -1);

            Assert.Throws<Exception>(calculate);
        }

        [Test]
        public void getDefenseCost_LevelZero_ThrowsException()
        {
            TestDelegate calculate = () => CostCalculator.getDefenseCost(Defense.Type.AntiBalisticMissiles, 0);

            Assert.Throws<Exception>(calculate);
        }

        [TestCase(Defense.Type.RocletLauncher, 5, 10000, 0, 0, 0)]
        [TestCase(Defense.Type.LightLaser, 5, 7500, 2500, 0, 0)]
        [TestCase(Defense.Type.HeavyLaser, 5, 30000, 10000, 0, 0)]
        [TestCase(Defense.Type.GaussCannon, 5, 100000, 75000, 10000, 0)]
        [TestCase(Defense.Type.IonCannon, 5, 10000, 30000, 0, 0)]
        [TestCase(Defense.Type.PlasmaTurret, 5, 250000, 250000, 150000, 0)]
        [TestCase(Defense.Type.SmallShieldDome, 5, 50000, 50000, 0, 0)]
        [TestCase(Defense.Type.LargeShieldDome, 5, 250000, 250000, 0, 0)]
        [TestCase(Defense.Type.AntiBalisticMissiles, 5, 40000, 0, 10000, 0)]
        [TestCase(Defense.Type.InterplanetaryMissiles, 5, 62500, 12500, 50000, 0)]
        public void getDefenseCost_CorrectArguments_OK(Defense.Type type, int quantity, long metal, long crystal, long deuter, long energy)
        {
            var expected = new Cost(metal, crystal, deuter, energy);

            var result = CostCalculator.getDefenseCost(type, quantity);

            Assert.AreEqual(expected.resources.getMetalQuantity(), result.resources.getMetalQuantity());
            Assert.AreEqual(expected.resources.getCrystalQuantity(), result.resources.getCrystalQuantity());
            Assert.AreEqual(expected.resources.getDeuterQuantity(), result.resources.getDeuterQuantity());
            Assert.AreEqual(expected.energy.getValue(), result.energy.getValue());
        }

    }
}
