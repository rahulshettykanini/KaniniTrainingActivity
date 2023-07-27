using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace transport.Models;

public partial class ShipsContext : DbContext
{
    public ShipsContext()
    {
    }

    public ShipsContext(DbContextOptions<ShipsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Ship> Ships { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Cname).HasName("PK__customer__87754D1C217B0697");

            entity.ToTable("customer");

            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .HasColumnName("cname");
            entity.Property(e => e.Destination)
                .HasMaxLength(20)
                .HasColumnName("destination");
            entity.Property(e => e.Product)
                .HasMaxLength(20)
                .HasColumnName("product");
            entity.Property(e => e.Ship)
                .HasMaxLength(20)
                .HasColumnName("ship");
            entity.Property(e => e.Source)
                .HasMaxLength(20)
                .HasColumnName("source");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Ship>(entity =>
        {
            entity.HasKey(e => e.Sname).HasName("PK__ship__0F1ED582A0746775");

            entity.ToTable("ship");

            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .HasColumnName("sname");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.Ending)
                .HasMaxLength(20)
                .HasColumnName("ending");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Starting)
                .HasMaxLength(20)
                .HasColumnName("starting");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
