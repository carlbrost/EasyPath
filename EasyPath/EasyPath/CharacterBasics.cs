using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPath
{
   public class CharacterBasics
    {
        public class Stats
        {
            public int Str { get; set; }
            public int Dex { get; set; }
            public int Con { get; set; }
            public int Int { get; set; }
            public int Wis { get; set; }
            public int Cha { get; set; }
        }

        public class Saves
        {
            public int Fort { get; set; }
            public int Reflex { get; set; }
            public int Will { get; set; }

        }

        public class Armor
        {
            public int ShieldBonus { get; set; }
            public int NaturalArmorBonus { get; set; }
            public int DexArmorBonus { get; set; }
            public int DodgeBonus { get; set; }
        }





    }
}
