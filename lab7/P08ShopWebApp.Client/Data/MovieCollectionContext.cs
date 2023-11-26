using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using P08ShopWebApp.Client.Models;

namespace P08ShopWebApp.Client.Data;

public partial class MovieCollectionContext : DbContext
{
    public MovieCollectionContext()
    {
    }

    public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.CountryOfOrigin).HasMaxLength(40);
            entity.Property(e => e.ReleaseDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.LengthInMinutes).HasDefaultValue(0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
