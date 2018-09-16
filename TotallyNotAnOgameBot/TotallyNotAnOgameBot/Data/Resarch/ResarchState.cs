using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resarch
{
    class ResarchState
    {
        public Resarch EnergyTechnology;
        public Resarch LaserTechnology;
        public Resarch IonTechnology;
        public Resarch HyperspaceTechnology;
        public Resarch PlasmaTechnology;
        public Resarch EspionageTechnology;
        public Resarch ComputerTechnology;
        public Resarch Astrophysics;
        public Resarch IntergalacticResearchNetwork;
        public Resarch GravitonTechnology;
        public Resarch WeaponsTechnology;
        public Resarch ShieldingTechnology;
        public Resarch ArmourTechnology;
        public Resarch CombustionDrive;
        public Resarch ImpulseDrive;
        public Resarch HyperspaceDrive;

        public ResarchState()
        {
            EnergyTechnology = new Resarch(Resarch.Type.EnergyTechnology, 0);
            LaserTechnology = new Resarch(Resarch.Type.LaserTechnology, 0);
            IonTechnology = new Resarch(Resarch.Type.IonTechnology, 0);
            HyperspaceTechnology = new Resarch(Resarch.Type.HyperspaceTechnology, 0);
            PlasmaTechnology = new Resarch(Resarch.Type.PlasmaTechnology, 0);
            EspionageTechnology = new Resarch(Resarch.Type.EspionageTechnology, 0);
            ComputerTechnology = new Resarch(Resarch.Type.ComputerTechnology, 0);
            Astrophysics = new Resarch(Resarch.Type.Astrophysics, 0);
            IntergalacticResearchNetwork = new Resarch(Resarch.Type.IntergalacticResearchNetwork, 0);
            GravitonTechnology = new Resarch(Resarch.Type.GravitonTechnology, 0);
            WeaponsTechnology = new Resarch(Resarch.Type.WeaponsTechnology, 0);
            ShieldingTechnology = new Resarch(Resarch.Type.ShieldingTechnology, 0);
            ArmourTechnology = new Resarch(Resarch.Type.ArmourTechnology, 0);
            CombustionDrive = new Resarch(Resarch.Type.CombustionDrive, 0);
            ImpulseDrive = new Resarch(Resarch.Type.ImpulseDrive, 0);
            HyperspaceDrive = new Resarch(Resarch.Type.HyperspaceDrive, 0);
        }

        public void add(ResarchState otherResarch)
        {
            EnergyTechnology.addLevel(otherResarch.EnergyTechnology.getLevel());
            LaserTechnology.addLevel(otherResarch.LaserTechnology.getLevel());
            IonTechnology.addLevel(otherResarch.IonTechnology.getLevel());
            HyperspaceTechnology.addLevel(otherResarch.HyperspaceTechnology.getLevel());
            PlasmaTechnology.addLevel(otherResarch.PlasmaTechnology.getLevel());
            EspionageTechnology.addLevel(otherResarch.EspionageTechnology.getLevel());
            ComputerTechnology.addLevel(otherResarch.ComputerTechnology.getLevel());
            Astrophysics.addLevel(otherResarch.Astrophysics.getLevel());
            IntergalacticResearchNetwork.addLevel(otherResarch.IntergalacticResearchNetwork.getLevel());
            GravitonTechnology.addLevel(otherResarch.GravitonTechnology.getLevel());
            WeaponsTechnology.addLevel(otherResarch.WeaponsTechnology.getLevel());
            ShieldingTechnology.addLevel(otherResarch.ShieldingTechnology.getLevel());
            ArmourTechnology.addLevel(otherResarch.ArmourTechnology.getLevel());
            CombustionDrive.addLevel(otherResarch.CombustionDrive.getLevel());
            ImpulseDrive.addLevel(otherResarch.ImpulseDrive.getLevel());
            HyperspaceDrive.addLevel(otherResarch.HyperspaceDrive.getLevel());
        }

        public void substract(ResarchState otherResarch)
        {
            EnergyTechnology.substractLevel(otherResarch.EnergyTechnology.getLevel());
            LaserTechnology.substractLevel(otherResarch.LaserTechnology.getLevel());
            IonTechnology.substractLevel(otherResarch.IonTechnology.getLevel());
            HyperspaceTechnology.substractLevel(otherResarch.HyperspaceTechnology.getLevel());
            PlasmaTechnology.substractLevel(otherResarch.PlasmaTechnology.getLevel());
            EspionageTechnology.substractLevel(otherResarch.EspionageTechnology.getLevel());
            ComputerTechnology.substractLevel(otherResarch.ComputerTechnology.getLevel());
            Astrophysics.substractLevel(otherResarch.Astrophysics.getLevel());
            IntergalacticResearchNetwork.substractLevel(otherResarch.IntergalacticResearchNetwork.getLevel());
            GravitonTechnology.substractLevel(otherResarch.GravitonTechnology.getLevel());
            WeaponsTechnology.substractLevel(otherResarch.WeaponsTechnology.getLevel());
            ShieldingTechnology.substractLevel(otherResarch.ShieldingTechnology.getLevel());
            ArmourTechnology.substractLevel(otherResarch.ArmourTechnology.getLevel());
            CombustionDrive.substractLevel(otherResarch.CombustionDrive.getLevel());
            ImpulseDrive.substractLevel(otherResarch.ImpulseDrive.getLevel());
            HyperspaceDrive.substractLevel(otherResarch.HyperspaceDrive.getLevel());
        }
    }
}
