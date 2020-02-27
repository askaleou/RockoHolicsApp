using Microsoft.AspNet.Identity.EntityFramework;
using RockoHolicsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Grade> Grades { get; set; }




        public ApplicationDbContext()
            : base("RockoHolicsApp", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();

            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRole");
            modelBuilder.Entity<IdentityUserRole>().ToTable("AspNetUserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("AspNetUserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("AspNetUserClaim");
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUser");

        }

    }
}
