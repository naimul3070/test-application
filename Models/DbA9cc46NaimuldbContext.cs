using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test_application.Models;

public partial class DbA9cc46NaimuldbContext : DbContext
{
    public DbA9cc46NaimuldbContext()
    {
    }

    public DbA9cc46NaimuldbContext(DbContextOptions<DbA9cc46NaimuldbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credential> Credentials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SQL5063.site4now.net;Database=db_a9cc46_naimuldb;Trusted_Connection=false;User Id=db_a9cc46_naimuldb_admin;Password=Shimul01833455558;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credential>(entity =>
        {
            entity.ToTable("Credential");

            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
