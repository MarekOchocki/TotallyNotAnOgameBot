using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Defences
{
    class DefenceState
    {
        public Defense RocletLauncher;
        public Defense LightLaser;
        public Defense HeavyLaser;
        public Defense GaussCannon;
        public Defense IonCannon;
        public Defense PlasmaTurret;
        public Defense SmallShieldDome;
        public Defense LargeShieldDome;
        public Defense AntiBalisticMissiles;
        public Defense InterplanetaryMissiles;

        public DefenceState()
        {
            RocletLauncher = new Defense(Defense.Type.RocletLauncher, 0);
            LightLaser = new Defense(Defense.Type.LightLaser, 0);
            HeavyLaser = new Defense(Defense.Type.HeavyLaser, 0);
            GaussCannon = new Defense(Defense.Type.GaussCannon, 0);
            IonCannon = new Defense(Defense.Type.IonCannon, 0);
            PlasmaTurret = new Defense(Defense.Type.PlasmaTurret, 0);
            SmallShieldDome = new Defense(Defense.Type.SmallShieldDome, 0);
            LargeShieldDome = new Defense(Defense.Type.LargeShieldDome, 0);
            AntiBalisticMissiles = new Defense(Defense.Type.AntiBalisticMissiles, 0);
            InterplanetaryMissiles = new Defense(Defense.Type.InterplanetaryMissiles, 0);
        }

        public void add(DefenceState otherDefenceState)
        {
            RocletLauncher.addQuantity(otherDefenceState.RocletLauncher.getQuantity());
            LightLaser.addQuantity(otherDefenceState.LightLaser.getQuantity());
            HeavyLaser.addQuantity(otherDefenceState.HeavyLaser.getQuantity());
            GaussCannon.addQuantity(otherDefenceState.GaussCannon.getQuantity());
            IonCannon.addQuantity(otherDefenceState.IonCannon.getQuantity());
            PlasmaTurret.addQuantity(otherDefenceState.PlasmaTurret.getQuantity());
            SmallShieldDome.addQuantity(otherDefenceState.SmallShieldDome.getQuantity());
            LargeShieldDome.addQuantity(otherDefenceState.LargeShieldDome.getQuantity());
            AntiBalisticMissiles.addQuantity(otherDefenceState.AntiBalisticMissiles.getQuantity());
            InterplanetaryMissiles.addQuantity(otherDefenceState.InterplanetaryMissiles.getQuantity());
        }

        public void substract(DefenceState otherDefenceState)
        {
            RocletLauncher.substractQuantity(otherDefenceState.RocletLauncher.getQuantity());
            LightLaser.substractQuantity(otherDefenceState.LightLaser.getQuantity());
            HeavyLaser.substractQuantity(otherDefenceState.HeavyLaser.getQuantity());
            GaussCannon.substractQuantity(otherDefenceState.GaussCannon.getQuantity());
            IonCannon.substractQuantity(otherDefenceState.IonCannon.getQuantity());
            PlasmaTurret.substractQuantity(otherDefenceState.PlasmaTurret.getQuantity());
            SmallShieldDome.substractQuantity(otherDefenceState.SmallShieldDome.getQuantity());
            LargeShieldDome.substractQuantity(otherDefenceState.LargeShieldDome.getQuantity());
            AntiBalisticMissiles.substractQuantity(otherDefenceState.AntiBalisticMissiles.getQuantity());
            InterplanetaryMissiles.substractQuantity(otherDefenceState.InterplanetaryMissiles.getQuantity());
        }
    }
}
