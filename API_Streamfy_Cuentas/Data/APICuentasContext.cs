using System;
using System.Collections.Generic;
using APICuentas.Models;
using Microsoft.EntityFrameworkCore;

namespace APICuentas.Data;

public partial class APICuentasContext : DbContext
{
    public APICuentasContext(DbContextOptions<APICuentasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Cuenta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Correo).HasName("PRIMARY");

            entity.ToTable("cuenta");

            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .HasColumnName("correo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .HasColumnName("apellido");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .HasColumnName("contraseña");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasColumnType("int(100)")
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
