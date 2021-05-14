using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectZeus.Database.Model;

namespace ProjectZeus.Database
{
    public class ZeusContext : DbContext
    {
        //as you add "tables" as classes in the model folder, add them here as well or it won't be aware of them
        //then, before you run the code, use the console to do Add-Migration "{name}", when you run it it will automatically update the db
        //or you can do update-database if you prefer
        public virtual DbSet<Mythology> Mythologies { get; set; }
        public virtual DbSet<God> Gods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //PUT SQL CONNECTION STRING BELOW
            optionsBuilder.UseSqlServer("Server=tcp:sql-pz-1.database.windows.net,1433;Initial Catalog=db-pz-1;Persist Security Info=False;User ID=SQL_Web;Password=tBoD*D9Sjv@I;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define any indexes etc

            modelBuilder.Entity<Mythology>().HasData(new List<Mythology>
            {
                new Mythology {Id = 1, Name = "Greek"},
                new Mythology {Id = 2, Name = "Norse"}
            });

            
            //some dummy seed data
            modelBuilder.Entity<God>().HasData(new List<God>
            {
                new God {Id = 1, Name = "Odin", MythologyId = 2},
                new God {Id = 2, Name = "Zeus", MythologyId = 1},
                new God {Id = 3, Name = "Loki", MythologyId = 2},
                new God {Id = 4, Name = "Thor", MythologyId = 2},
                new God {Id = 5, Name = "Freya", MythologyId = 2},
                new God {Id = 6, Name = "Hera", MythologyId = 1},
                new God {Id = 7, Name = "Athena", MythologyId = 1},
                new God {Id = 8, Name = "Achilles", MythologyId = 1},
                new God {Id = 9, Name = "Hercules", MythologyId = 1},
                new God {Id = 10, Name = "Hermes", MythologyId = 1}
            });
        }

    }
}
