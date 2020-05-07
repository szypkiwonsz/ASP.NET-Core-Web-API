using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class HospitalContext : DbContext
    {
        private string connection = "Server=(localdb)\\mssqllocaldb;database=Hospital;Trusted_Connection=True;"; public DbSet<Operation> Operations { get; set; }
        public DbSet<HospitalWard> HospitalWards { get; set; }
        public DbSet<MedicalProcedure> MedicalProcedures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>().HasOne(operation => operation.HospitalWard).WithOne(hospitalward => hospitalward.Operation).HasForeignKey<HospitalWard>(hospitalward => hospitalward.OperationId);

            modelBuilder.Entity<Operation>().HasMany(operation => operation.MedicalProcedures).WithOne(medicalprocedure => medicalprocedure.Operation);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(connection); }
    }
}
