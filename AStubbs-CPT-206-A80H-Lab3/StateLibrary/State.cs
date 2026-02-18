using System;
using System.Collections.Generic;
using System.Text;

namespace StateLibrary
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string FlagDesc { get; set; }
        public string Flower { get; set; }
        public string Bird { get; set; }
        public string Three { get; set; }
        public string Capital { get; set; }
        public double Income { get; set; }
        public double Percent { get; set; }

        public State(int iD, string name, int population, string flagDesc, string flower, string bird, string three, string capital, double income, double percent)
        {
            ID = iD;
            Name = name;
            Population = population;
            FlagDesc = flagDesc;
            Flower = flower;
            Bird = bird;
            Three = three;
            Capital = capital;
            Income = income;
            Percent = percent;


        }
    }
}

