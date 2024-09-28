using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalBookAPI.Models;

public partial class KitabBaza2Context : DbContext
{
    public KitabBaza2Context()
    {
    }

    public KitabBaza2Context(DbContextOptions<KitabBaza2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CildTipi> CildTipis { get; set; }

    public virtual DbSet<Dil> Dils { get; set; }

    public virtual DbSet<Isci> Iscis { get; set; }

    public virtual DbSet<Janr> Janrs { get; set; }

    public virtual DbSet<Kitab> Kitabs { get; set; }

    public virtual DbSet<KitabSatish> KitabSatishes { get; set; }

    public virtual DbSet<Nesriyyat> Nesriyyats { get; set; }

    public virtual DbSet<Tercumeci> Tercumecis { get; set; }

    public virtual DbSet<Yazici> Yazicis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-E6J1KMO\\SQLEXPRESS;Database=KitabBaza2;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CildTipi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cildTipi__3213E83F7E79CFC1");

            entity.ToTable("cildTipi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Dil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dil__3213E83FD3348F0F");

            entity.ToTable("dil");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dil1)
                .HasMaxLength(20)
                .HasColumnName("dil");
        });

        modelBuilder.Entity<Isci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__isci__3213E83F8663BDA3");

            entity.ToTable("isci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(20)
                .HasColumnName("ad");
            entity.Property(e => e.RehberId).HasColumnName("rehberID");
        });

        modelBuilder.Entity<Janr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Janr__3213E83FBFC5A913");

            entity.ToTable("Janr");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Janr1)
                .HasMaxLength(20)
                .HasColumnName("janr");
        });

        modelBuilder.Entity<Kitab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kitab__3213E83F81BCB255");

            entity.ToTable("Kitab", tb =>
                {
                    tb.HasTrigger("ChangeValue");
                    tb.HasTrigger("KitabSayAzalt");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(20)
                .HasColumnName("ad");
            entity.Property(e => e.BookImg).HasColumnType("image");
            entity.Property(e => e.CildTipiId).HasColumnName("cildTipiID");
            entity.Property(e => e.DilId).HasColumnName("dilID");
            entity.Property(e => e.JanrId).HasColumnName("janrID");
            entity.Property(e => e.NesriyyatId).HasColumnName("nesriyyatID");
            entity.Property(e => e.Qiymet).HasColumnName("qiymet");
            entity.Property(e => e.Say).HasColumnName("say");
            entity.Property(e => e.Tarix).HasColumnType("date");
            entity.Property(e => e.TercumeciId).HasColumnName("tercumeciID");
            entity.Property(e => e.YaziciId).HasColumnName("yaziciID");

            entity.HasOne(d => d.CildTipi).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.CildTipiId)
                .HasConstraintName("FK__Kitab__cildTipiI__5535A963");

            entity.HasOne(d => d.Dil).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.DilId)
                .HasConstraintName("FK__Kitab__dilID__5812160E");

            entity.HasOne(d => d.Janr).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.JanrId)
                .HasConstraintName("FK__Kitab__janrID__5629CD9C");

            entity.HasOne(d => d.Nesriyyat).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.NesriyyatId)
                .HasConstraintName("FK__Kitab__nesriyyat__571DF1D5");

            entity.HasOne(d => d.Tercumeci).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.TercumeciId)
                .HasConstraintName("FK__Kitab__tercumeci__59FA5E80");

            entity.HasOne(d => d.Yazici).WithMany(p => p.Kitabs)
                .HasForeignKey(d => d.YaziciId)
                .HasConstraintName("FK__Kitab__yaziciID__59063A47");
        });

        modelBuilder.Entity<KitabSatish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kitab_sa__3213E83F2033E4F9");

            entity.ToTable("kitab_satish");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KitabId).HasColumnName("kitabID");
            entity.Property(e => e.Say).HasColumnName("say");
            entity.Property(e => e.Tarix)
                .HasColumnType("date")
                .HasColumnName("tarix");

            entity.HasOne(d => d.Kitab).WithMany(p => p.KitabSatishes)
                .HasForeignKey(d => d.KitabId)
                .HasConstraintName("FK__kitab_sat__kitab__6FE99F9F");
        });

        modelBuilder.Entity<Nesriyyat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__nesriyya__3213E83F395C03BB");

            entity.ToTable("nesriyyat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nesriyyat1)
                .HasMaxLength(20)
                .HasColumnName("nesriyyat");
        });

        modelBuilder.Entity<Tercumeci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tercumec__3213E83FEF2F6228");

            entity.ToTable("tercumeci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tercumeci1)
                .HasMaxLength(20)
                .HasColumnName("tercumeci");
        });

        modelBuilder.Entity<Yazici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__yazici__3213E83FC744149D");

            entity.ToTable("yazici");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Yazici1)
                .HasMaxLength(20)
                .HasColumnName("yazici");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
