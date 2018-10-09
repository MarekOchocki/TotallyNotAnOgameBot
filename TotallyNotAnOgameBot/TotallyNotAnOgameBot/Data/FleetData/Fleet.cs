using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.FleetData
{
    public class Fleet
    {
        public Spaceships smallCargo;
        public Spaceships largeCargo;
        public Spaceships colonyShip;
        public Spaceships recycler;
        public Spaceships espionageProbe;
        public Spaceships solarSatelite;
        public Spaceships lightFighter;
        public Spaceships heavyFighter;
        public Spaceships crusier;
        public Spaceships battleship;
        public Spaceships battlecrusier;
        public Spaceships bomber;
        public Spaceships destroyer;
        public Spaceships deathstar;

        public Fleet()
        {
            smallCargo = new Spaceships(Spaceships.Type.SmallCargo, 0);
            largeCargo = new Spaceships(Spaceships.Type.LargeCargo, 0 );
            colonyShip = new Spaceships(Spaceships.Type.ColonyShip, 0 );
            recycler = new Spaceships(Spaceships.Type.Recycler, 0);
            espionageProbe = new Spaceships(Spaceships.Type.EspionageProbe, 0);
            solarSatelite = new Spaceships(Spaceships.Type.SolarSatelite, 0);
            lightFighter = new Spaceships(Spaceships.Type.LightFighter, 0);
            heavyFighter = new Spaceships(Spaceships.Type.HeavyFighter, 0);
            crusier = new Spaceships(Spaceships.Type.Crusier, 0);
            battleship = new Spaceships(Spaceships.Type.Battleship, 0);
            battlecrusier = new Spaceships(Spaceships.Type.Battlecrusier, 0);
            bomber = new Spaceships(Spaceships.Type.Bomber, 0);
            destroyer = new Spaceships(Spaceships.Type.Destroyer, 0);
            deathstar = new Spaceships(Spaceships.Type.Deathstar, 0);
        }

        public void add(Fleet otherFleet)
        {
            smallCargo.addQuantity(otherFleet.smallCargo.getQuantity()); 
            largeCargo.addQuantity(otherFleet.largeCargo.getQuantity()); 
            colonyShip.addQuantity(otherFleet.colonyShip.getQuantity()); 
            recycler.addQuantity(otherFleet.recycler.getQuantity()); 
            espionageProbe.addQuantity(otherFleet.espionageProbe.getQuantity()); 
            solarSatelite.addQuantity(otherFleet.solarSatelite.getQuantity()); 
            lightFighter.addQuantity(otherFleet.lightFighter.getQuantity()); 
            heavyFighter.addQuantity(otherFleet.heavyFighter.getQuantity()); 
            crusier.addQuantity(otherFleet.crusier.getQuantity()); 
            battleship.addQuantity(otherFleet.battleship.getQuantity()); 
            battlecrusier.addQuantity(otherFleet.battlecrusier.getQuantity()); 
            bomber.addQuantity(otherFleet.bomber.getQuantity()); 
            destroyer.addQuantity(otherFleet.destroyer.getQuantity()); 
            deathstar.addQuantity(otherFleet.deathstar.getQuantity()); 
        }

        public void substract(Fleet otherFleet)
        {
            smallCargo.substractQuantity(otherFleet.smallCargo.getQuantity());
            largeCargo.substractQuantity(otherFleet.largeCargo.getQuantity());
            colonyShip.substractQuantity(otherFleet.colonyShip.getQuantity());
            recycler.substractQuantity(otherFleet.recycler.getQuantity());
            espionageProbe.substractQuantity(otherFleet.espionageProbe.getQuantity());
            solarSatelite.substractQuantity(otherFleet.solarSatelite.getQuantity());
            lightFighter.substractQuantity(otherFleet.lightFighter.getQuantity());
            heavyFighter.substractQuantity(otherFleet.heavyFighter.getQuantity());
            crusier.substractQuantity(otherFleet.crusier.getQuantity());
            battleship.substractQuantity(otherFleet.battleship.getQuantity());
            battlecrusier.substractQuantity(otherFleet.battlecrusier.getQuantity());
            bomber.substractQuantity(otherFleet.bomber.getQuantity());
            destroyer.substractQuantity(otherFleet.destroyer.getQuantity());
            deathstar.substractQuantity(otherFleet.deathstar.getQuantity());
        }
    }
}
