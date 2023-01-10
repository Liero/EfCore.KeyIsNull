
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sylex.ISYS.Domain.Manufacture.Models;
using System;

#nullable disable

namespace Sylex.ISYS.Domain.Manufacture
{
    public partial class ManufactureDbContext : DbContext
    {
        public ManufactureDbContext()
        {
        }

        public ManufactureDbContext(DbContextOptions<ManufactureDbContext> options)
            : base(options)
        {
        }

     
        public virtual DbSet<ČíselníkMateriál> ČíselníkMateriál { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                   .UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Database=AllTogetherNow")
                   .LogTo(Console.WriteLine, LogLevel.Information)
                   .EnableSensitiveDataLogging();
            }
        }
    }
}
