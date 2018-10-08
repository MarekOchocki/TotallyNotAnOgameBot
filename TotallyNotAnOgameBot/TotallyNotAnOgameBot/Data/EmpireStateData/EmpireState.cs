﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Research;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    public class EmpireState
    {
        public ResearchState research;
        public int amountOfPlanets;
        public PlanetState[] planets;

        public EmpireState(int planetQuantity = 1)
        {
            if(planetQuantity < 0)
            {
                throw new LessThanZeroException();
            }else if(planetQuantity == 0)
            {
                throw new EqualZeroException();
            }
            amountOfPlanets = planetQuantity;
            planets = new PlanetState[planetQuantity];
            planets[1].name = "Main";
            research = new ResearchState();
        }
    }
}
