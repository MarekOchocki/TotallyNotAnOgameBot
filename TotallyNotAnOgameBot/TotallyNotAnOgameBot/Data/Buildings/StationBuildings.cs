using System;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    public class StationBuildings
    {
        public Building RoboticsFactory;
        public Building Shipyard;
        public Building ResarchLab;
        public Building AllianceDepot;
        public Building MissileSilo;
        public Building NaniteFactory;
        public Building Terraformer;
        public Building SpaceDock;

        public StationBuildings()
        {
            RoboticsFactory = new Building(Building.Type.RoboticsFactory, 0);
            Shipyard = new Building(Building.Type.Shipyard, 0);
            ResarchLab = new Building(Building.Type.ResarchLab, 0);
            AllianceDepot = new Building(Building.Type.AllianceDepot, 0);
            MissileSilo = new Building(Building.Type.MissileSilo, 0);
            NaniteFactory = new Building(Building.Type.NaniteFactory, 0);
            Terraformer = new Building(Building.Type.Terraformer, 0);
            SpaceDock = new Building(Building.Type.SpaceDock, 0);
        }

        public void setBuildingLevel(Building.Type type, int level)
        {
            if (type == Building.Type.RoboticsFactory)
            {
                RoboticsFactory.setLevel(level);
            }
            else if (type == Building.Type.Shipyard)
            {
                Shipyard.setLevel(level);
            }
            else if (type == Building.Type.ResarchLab)
            {
                ResarchLab.setLevel(level);
            }
            else if (type == Building.Type.AllianceDepot)
            {
                AllianceDepot.setLevel(level);
            }
            else if (type == Building.Type.MissileSilo)
            {
                MissileSilo.setLevel(level);
            }
            else if (type == Building.Type.NaniteFactory)
            {
                NaniteFactory.setLevel(level);
            }
            else if (type == Building.Type.Terraformer)
            {
                Terraformer.setLevel(level);
            }
            else if (type == Building.Type.SpaceDock)
            {
                SpaceDock.setLevel(level);
            }
            else
                throw new Exception();
        }
    }
}
