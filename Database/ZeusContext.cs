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
        public virtual DbSet<Deity> Deities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //PUT SQL CONNECTION STRING BELOW
            optionsBuilder.UseSqlServer("Server=.;Database=ProjectZeus;Trusted_connection=True;");
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
            modelBuilder.Entity<Deity>().HasData(new List<Deity>
            {
                new Deity {Id = 1, Name = "Odin", MythologyId = 2},
                new Deity {Id = 2, Name = "Zeus", MythologyId = 1},
                new Deity {Id = 3, Name = "Loki", MythologyId = 2},
                new Deity {Id = 4, Name = "Thor", MythologyId = 2},
                new Deity {Id = 5, Name = "Freya", MythologyId = 2},
                new Deity {Id = 6, Name = "Hera", MythologyId = 1},
                new Deity {Id = 7, Name = "Athena", MythologyId = 1},
                new Deity {Id = 8, Name = "Achilles", MythologyId = 1},
                new Deity {Id = 9, Name = "Hercules", MythologyId = 1},
                new Deity {Id = 10, Name = "Hermes", MythologyId = 1}
            });
        }

    }
}
