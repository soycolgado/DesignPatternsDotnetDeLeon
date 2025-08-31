﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Models.Data;

public partial class DesignPatternsContext : DbContext
{
    public DesignPatternsContext()
    {
    }

    public DesignPatternsContext(DbContextOptions<DesignPatternsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=DesignPatterns;User=sa;Password=Lola_100314!;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>(entity =>
        {
            entity.HasKey(e => e.BeerId).HasName("Beer_pk");

            entity.ToTable("Beer");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Brand).WithMany(p => p.Beers)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Beer_Brand__fk");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("Brand_pk");

            entity.ToTable("Brand");

            entity.Property(e => e.BrandId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
