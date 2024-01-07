using EFCoreTrial_CodeFirst.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTrial_CodeFirst
{
    public class CodeFirstDbContext: DbContext
    {
        #region DbSets
        public DbSet<Human> Humans { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodConsumable> FoodConsumables { get; set; }

        #endregion
        public CodeFirstDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EFCoreTrials;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>(entity =>
            {
                entity.HasKey("Id");
            });
   
            base.OnModelCreating(modelBuilder);
        }
    }
}
