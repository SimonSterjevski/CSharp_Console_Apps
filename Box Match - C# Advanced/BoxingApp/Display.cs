using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace BoxingApp
{
    public class Display
    {
        public StreamWriter sw = new StreamWriter("report.txt");
        public void CalcAndDisplayInfo(Boxer attacker, Boxer defender)
        {
            Console.WriteLine($"{attacker.Name} throw {Calculator.punchType} with strenght {Calculator.attackerStrength}");
            sw.WriteLine($"{attacker.Name} throw {Calculator.punchType} with strenght {Calculator.attackerStrength}");
            if (Calculator.attackerStrength > Calculator.defenceAgility)
            {
                if (defender.Hitpoints < 1)
                {
                    Console.WriteLine($"Knockout!!! {defender.Name} is on the floor");
                    sw.WriteLine($"Knockout!!! {defender.Name} is on the floor");
                } else
                {
                    Console.WriteLine($"{defender.Name} was hit for {Calculator.attackerStrength - Calculator.defenceAgility} damage.");
                    Console.WriteLine($"{defender.Name}: Hitpoints left: {defender.Hitpoints}");
                    sw.WriteLine($"{defender.Name} was hit for {Calculator.attackerStrength - Calculator.defenceAgility} damage.");
                    sw.WriteLine($"{defender.Name}: Hitpoints left: {defender.Hitpoints}");
                }
            }
            else
            {
                Console.WriteLine($"{defender.Name} escaped the punch!");
                sw.WriteLine($"{defender.Name} escaped the punch!");
            }
        }
       
        } 
    }

