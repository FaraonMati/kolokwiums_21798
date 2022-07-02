using kolokwium_21798.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwiums_21798.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {
        }
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Membership> MemberShips { get; set; }
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Membership>().HasKey(e =>new { e.MemberID,e.TeamID});
            modelBuilder.Entity<Membership>().HasOne<Member>(e =>e.Member).WithMany(p =>p.Membership);
            modelBuilder.Entity<Membership>().HasOne<Team>(e => e.Team).WithMany(p=>p.Membership);


        }


    }
}
