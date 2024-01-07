using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreFirstWebUI.Domain;

public partial class EfcoreTrialsContext : DbContext
{
    public EfcoreTrialsContext()
    {
    }

    public EfcoreTrialsContext(DbContextOptions<EfcoreTrialsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodConsumable> FoodConsumables { get; set; }

    public virtual DbSet<Human> Humans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.Property(e => e.Description).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
