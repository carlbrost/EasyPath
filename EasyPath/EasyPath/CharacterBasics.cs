using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPath
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

    public class Skills
    {
        public string off { get; set; }
        public string def { get; set; }
        public string edu { get; set; }
        public string spec { get; set; }
    }

    public class Racial
    {
        public string Race { get; set; }

        public string Subrace { get; set; }

    }

    public class Identity
    {
        public string name = "";

        public Stats stats = new Stats();

        public Skills skills = new Skills();

        public Racial race = new Racial();

        public Identity()
        {
        }

    }
}
