using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    class StationBuildings
    {
        public Buildings RoboticsFactory;
        public Buildings Shipyard;
        public Buildings ResarchLab;
        public Buildings AllianceDepot;
        public Buildings MissileSilo;
        public Buildings NaniteFactory;
        public Buildings Terraformer;
        public Buildings SpaceDock;

        public StationBuildings()
        {
            RoboticsFactory = new Buildings(Buildings.Type.RoboticsFactory, 0);
            Shipyard = new Buildings(Buildings.Type.Shipyard, 0);
            AllianceDepot = new Buildings(Buildings.Type.AllianceDepot, 0);
            MissileSilo = new Buildings(Buildings.Type.MissileSilo, 0);
            NaniteFactory = new Buildings(Buildings.Type.NaniteFactory, 0);
            Terraformer = new Buildings(Buildings.Type.Terraformer, 0);
            SpaceDock = new Buildings(Buildings.Type.SpaceDock, 0);
        }

        public void add(StationBuildings otherStationBuildings)
        {
            RoboticsFactory.addLevel(otherStationBuildings.RoboticsFactory.getLevel());
            Shipyard.addLevel(otherStationBuildings.Shipyard.getLevel());
            AllianceDepot.addLevel(otherStationBuildings.AllianceDepot.getLevel());
            MissileSilo.addLevel(otherStationBuildings.MissileSilo.getLevel());
            NaniteFactory.addLevel(otherStationBuildings.NaniteFactory.getLevel());
            Terraformer.addLevel(otherStationBuildings.Terraformer.getLevel());
            SpaceDock.addLevel(otherStationBuildings.SpaceDock.getLevel());
        }

        public void substract(StationBuildings otherStationBuildings)
        {
            RoboticsFactory.substractLevel(otherStationBuildings.RoboticsFactory.getLevel());
            Shipyard.substractLevel(otherStationBuildings.Shipyard.getLevel());
            AllianceDepot.substractLevel(otherStationBuildings.AllianceDepot.getLevel());
            MissileSilo.substractLevel(otherStationBuildings.MissileSilo.getLevel());
            NaniteFactory.substractLevel(otherStationBuildings.NaniteFactory.getLevel());
            Terraformer.substractLevel(otherStationBuildings.Terraformer.getLevel());
            SpaceDock.substractLevel(otherStationBuildings.SpaceDock.getLevel());
        }
    }
}
