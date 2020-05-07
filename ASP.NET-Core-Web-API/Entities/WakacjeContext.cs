using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class WakacjeContext : DbContext
    {
        private string polaczenie = "Server=(localdb)\\mssqllocaldb;database=Wakacje;Trusted_Connection=True;"; public DbSet<Wyjazd> Wyjazdy { get; set; }
        public DbSet<Miejsce> Miejsca { get; set; }
        public DbSet<Atrakcja> Atrakcje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wyjazd>().HasOne(wyjazd => wyjazd.Miejsce).WithOne(miejsce => miejsce.Wyjazd).HasForeignKey<Miejsce>(miejsce => miejsce.WyjazdId);

            modelBuilder.Entity<Wyjazd>().HasMany(wyjazd => wyjazd.Atrakcje).WithOne(atrakcja => atrakcja.Wyjazd);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(polaczenie); }
    }
}
