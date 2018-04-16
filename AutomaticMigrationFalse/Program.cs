using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticMigrationFalse
{
    partial class Program
    {
        public class FootballContext : DbContext
        {
            public DbSet<Team> Teams { get; set; }

            public DbSet<Player> Player  { get; set; }

            public DbSet<PlayerAddress> PlayerAddress { get; set; }

            public DbSet<Sponsor> Sponsors { get; set; }

            public FootballContext():base("FootballdbConnStr")
            {

            }

        }
        static void Main(string[] args)
        {

        }
    }
}
