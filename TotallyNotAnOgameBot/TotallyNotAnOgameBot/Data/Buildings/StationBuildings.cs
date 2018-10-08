using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            AllianceDepot = new Building(Building.Type.AllianceDepot, 0);
            MissileSilo = new Building(Building.Type.MissileSilo, 0);
            NaniteFactory = new Building(Building.Type.NaniteFactory, 0);
            Terraformer = new Building(Building.Type.Terraformer, 0);
            SpaceDock = new Building(Building.Type.SpaceDock, 0);
            ResarchLab = new Building(Building.Type.ResarchLab, 0);
        }
    }
}
