using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingApp
{
    public class BoxingMatch
    {
        
        public delegate void Hitting (Boxer attacker, Boxer defender);
        public event Hitting OnHitting;
      
        public int NumberOfPunches { get; set; }

        public BoxingMatch(int punches)
        {
            NumberOfPunches = punches;
        }
        public void PunchInfo(Boxer attacker, Boxer defender)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Punch happened");
            if (attacker.Attacker == true)
            {
                OnHittingCalc(attacker, defender);
                attacker.Attacker = false;
                defender.Attacker = true;
            } else
            {
                OnHittingCalc(defender, attacker);
                attacker.Attacker = true;
                defender.Attacker = false;
            }
           
           
        }
     
        public void OnHittingCalc(Boxer attacker, Boxer defender)
        {
            OnHitting(attacker, defender);
        }

    }
}
