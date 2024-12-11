using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cseresznye_Max38o.Mappa;

public partial class context_Szabaduloszoba : DbContext
{
    public context_Szabaduloszoba()
    {
    }

    public context_Szabaduloszoba(DbContextOptions<context_Szabaduloszoba> options)
        : base(options)
    {
    }

    public virtual DbSet<Foglalasok> Foglalasoks { get; set; }

    public virtual DbSet<Jatekosok> Jatekosoks { get; set; }

    public virtual DbSet<Szobak> Szobaks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=szabadulo.database.windows.net;Initial Catalog=Szabaduloszoba;User ID=Hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Foglalasok>(entity =>
        {
            entity.HasKey(e => e.FoglalasId).HasName("PK__Foglalas__5BAF4B292ED5B25F");

            entity.ToTable("Foglalasok");

            entity.Property(e => e.FoglalasId).HasColumnName("FoglalasID");
            entity.Property(e => e.Allapot)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Idopont).HasColumnType("datetime");
            entity.Property(e => e.JatekosId).HasColumnName("JatekosID");
            entity.Property(e => e.SzobaId).HasColumnName("SzobaID");


        });

        modelBuilder.Entity<Jatekosok>(entity =>
        {
            entity.HasKey(e => e.JatekosId).HasName("PK__Jatekoso__5543ECC8E1C79BE6");

            entity.ToTable("Jatekosok");

            entity.HasIndex(e => e.Email, "UQ__Jatekoso__A9D10534A58B7DE7").IsUnique();

            entity.Property(e => e.JatekosId).HasColumnName("JatekosID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nev)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Szobak>(entity =>
        {
            entity.HasKey(e => e.SzobaId).HasName("PK__Szobak__35DF4C76E5300FEC");

            entity.ToTable("Szobak");

            entity.Property(e => e.SzobaId).HasColumnName("SzobaID");
            entity.Property(e => e.KepForras)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nev)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tema)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
