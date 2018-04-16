using System;
using System.Collections;
using System.Collections.Generic;

namespace AutomaticMigrationFalse
{
    partial class Program
    {
        public class Team
        {
            public int TeamId { get; set; }
            public String Ad { get; set; }
            public short KurulusYili { get; set; }
            // Her Takımda birden fazla futbolcu olur 
            public virtual ICollection<Player> Players { get; set; }

            // Her takım birden fazla sponsordan destek alabilir!
            public virtual ICollection<Sponsor> Sponsors { get; set; }
            public Team()
            {
                Players = new HashSet<Player>();
                Sponsors = new HashSet<Sponsor>();
            }
        }
    }
}
