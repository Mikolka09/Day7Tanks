using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    class Tank
    {
        public string NameTank { get; private set; }
        public int Ammunition { get; private set; }
        public int Armor { get; private set; }
        public int Maneuverability { get; private set; }

        public Tank(String Name)
        {
            NameTank = Name;
            Ammunition = (new Random()).Next(0, 101);
            Armor = (new Random()).Next(0, 101);
            Maneuverability = (new Random()).Next(0, 101);
        }

        public static Tank operator *(Tank T1, Tank T2)
        {
            if (T1.Ammunition > T2.Ammunition && T1.Armor > T2.Armor ||
                T1.Ammunition > T2.Ammunition && T1.Maneuverability > T2.Maneuverability ||
                T1.Armor > T2.Armor && T1.Maneuverability > T2.Maneuverability)
            {
                return T1;
            }
            else if (T2.Ammunition > T1.Ammunition && T2.Armor > T1.Armor ||
                T2.Ammunition > T1.Ammunition && T2.Maneuverability > T1.Maneuverability ||
                T2.Armor > T1.Armor && T2.Maneuverability > T1.Maneuverability)
            {
                return T2;
            }

            return null;
        }

        public List<int> TankList(Tank T)
        {
            List<int> Tanks = null;
            Tanks.Add(T.Ammunition);
            Tanks.Add(T.Armor);
            Tanks.Add(T.Maneuverability);

            return Tanks;
        }

    }

}
