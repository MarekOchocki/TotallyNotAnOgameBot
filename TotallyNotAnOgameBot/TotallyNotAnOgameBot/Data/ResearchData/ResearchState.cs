using System;

namespace TotallyNotAnOgameBot.Data.ResearchData
{
    public class ResearchState
    {
        public Research EnergyTechnology;
        public Research LaserTechnology;
        public Research IonTechnology;
        public Research HyperspaceTechnology;
        public Research PlasmaTechnology;
        public Research EspionageTechnology;
        public Research ComputerTechnology;
        public Research Astrophysics;
        public Research IntergalacticResearchNetwork;
        public Research GravitonTechnology;
        public Research WeaponsTechnology;
        public Research ShieldingTechnology;
        public Research ArmourTechnology;
        public Research CombustionDrive;
        public Research ImpulseDrive;
        public Research HyperspaceDrive;

        public ResearchState()
        {
            EnergyTechnology = new Research(Research.Type.EnergyTechnology, 0);
            LaserTechnology = new Research(Research.Type.LaserTechnology, 0);
            IonTechnology = new Research(Research.Type.IonTechnology, 0);
            HyperspaceTechnology = new Research(Research.Type.HyperspaceTechnology, 0);
            PlasmaTechnology = new Research(Research.Type.PlasmaTechnology, 0);
            EspionageTechnology = new Research(Research.Type.EspionageTechnology, 0);
            ComputerTechnology = new Research(Research.Type.ComputerTechnology, 0);
            Astrophysics = new Research(Research.Type.Astrophysics, 0);
            IntergalacticResearchNetwork = new Research(Research.Type.IntergalacticResearchNetwork, 0);
            GravitonTechnology = new Research(Research.Type.GravitonTechnology, 0);
            WeaponsTechnology = new Research(Research.Type.WeaponsTechnology, 0);
            ShieldingTechnology = new Research(Research.Type.ShieldingTechnology, 0);
            ArmourTechnology = new Research(Research.Type.ArmourTechnology, 0);
            CombustionDrive = new Research(Research.Type.CombustionDrive, 0);
            ImpulseDrive = new Research(Research.Type.ImpulseDrive, 0);
            HyperspaceDrive = new Research(Research.Type.HyperspaceDrive, 0);
        }

        public void setResearchLevel(Research.Type type, int level)
        {
            if (type == Research.Type.EnergyTechnology)
            {
                EnergyTechnology.setLevel(level);
            }
            else if (type == Research.Type.LaserTechnology)
            {
                LaserTechnology.setLevel(level);
            }
            else if (type == Research.Type.IonTechnology)
            {
                IonTechnology.setLevel(level);
            }
            else if (type == Research.Type.HyperspaceTechnology)
            {
                HyperspaceTechnology.setLevel(level);
            }
            else if (type == Research.Type.PlasmaTechnology)
            {
                PlasmaTechnology.setLevel(level);
            }
            else if (type == Research.Type.EspionageTechnology)
            {
                EspionageTechnology.setLevel(level);
            }
            else if (type == Research.Type.ComputerTechnology)
            {
                ComputerTechnology.setLevel(level);
            }
            else if (type == Research.Type.Astrophysics)
            {
                Astrophysics.setLevel(level);
            }
            else if (type == Research.Type.IntergalacticResearchNetwork)
            {
                IntergalacticResearchNetwork.setLevel(level);
            }
            else if (type == Research.Type.GravitonTechnology)
            {
                GravitonTechnology.setLevel(level);
            }
            else if (type == Research.Type.WeaponsTechnology)
            {
                WeaponsTechnology.setLevel(level);
            }
            else if (type == Research.Type.ShieldingTechnology)
            {
                ShieldingTechnology.setLevel(level);
            }
            else if (type == Research.Type.ArmourTechnology)
            {
                ArmourTechnology.setLevel(level);
            }
            else if (type == Research.Type.CombustionDrive)
            {
                CombustionDrive.setLevel(level);
            }
            else if (type == Research.Type.ImpulseDrive)
            {
                ImpulseDrive.setLevel(level);
            }
            else if (type == Research.Type.HyperspaceDrive)
            {
                HyperspaceDrive.setLevel(level);
            }
                throw new Exception();
        }
    }
}
