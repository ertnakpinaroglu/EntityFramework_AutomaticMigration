using System.Collections;
using System.Collections.Generic;

namespace AutomaticMigrationFalse
{
    partial class Program
    {
        public class Sponsor
        {
            public int SponsorId { get; set; }

            public string Ad { get; set; }

            // Bir sponsor aynı anda birden fazla takımın sponsoru olabilir!
            public virtual ICollection<Team> Team { get; set; }

            public Sponsor()
            {
                Team = new HashSet<Team>();
            }


        }
    }
}
