using BotanicalGarden.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanicalGarden.Model
{
    class BotanicalGardenContext : DbContext
    {
        static BotanicalGardenContext()
        {
            Database.SetInitializer(new BotanicalGardenInitializer());
        }
        public BotanicalGardenContext() : base("DbConnection") { }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

    }
}
