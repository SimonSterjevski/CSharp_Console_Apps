using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingApp
{
    public class Boxer
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Hitpoints { get; set; }
        public bool Attacker { get; set; }
        public Dictionary<string, int> Strength { get; set; }
        public Dictionary<string, int> Agility { get; set; }

        public Boxer(string name, int weight, int hitpoint, bool attacker, Dictionary<string, int> strenght, Dictionary<string, int> agility)
        {
            Name = name;
            Weight = weight;
            Hitpoints = hitpoint;
            Attacker = attacker;
            Strength = strenght;
            Agility = agility;
        }
    }
}
