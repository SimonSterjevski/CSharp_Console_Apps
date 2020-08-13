using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BoxingApp
{
    public class Calculator
    {

        public delegate void RoundCalculated(Boxer attacker, Boxer defender);
        public event RoundCalculated onRoundCalc;

        public static string punchType;
        public static int attackerStrength;
        public static int defenceAgility;

        public void CalcInfo(Boxer attacker, Boxer defender)
        {
            Random random = new Random();

            int typeNum = random.Next(0, 4);
            switch (typeNum)
            {
                case 0:
                    {
                        attackerStrength = attacker.Strength["Cross"];
                        defenceAgility = random.Next(0, defender.Agility["Cross"] + 1);
                        punchType = "Cross";
                        break;
                    };
                case 1:
                    {
                        attackerStrength = attacker.Strength["Jab"];
                        defenceAgility = random.Next(0, defender.Agility["Jab"] + 1);
                        punchType = "Jab";
                        break;
                    }
                case 2:
                    {
                        attackerStrength = attacker.Strength["Uppercut"];
                        defenceAgility = random.Next(0, defender.Agility["Uppercut"] + 1);
                        punchType = "Uppercut";
                        break;
                    }
                case 3:
                    {
                        attackerStrength = attacker.Strength["Hook"];
                        defenceAgility = random.Next(0, defender.Agility["Hook"] + 1);
                        punchType = "Hook";
                        break;
                    }
            }
            if (attackerStrength > defenceAgility)
            {
                defender.Hitpoints -= attackerStrength - defenceAgility;
            }
            onRoundCalc(attacker, defender);
        }
    }
}
