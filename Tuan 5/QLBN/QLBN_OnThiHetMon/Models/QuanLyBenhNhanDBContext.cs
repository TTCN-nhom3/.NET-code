﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLBN_OnThiHetMon.Models
{
    public partial class QuanLyBenhNhanDBContext : DbContext
    {
        public QuanLyBenhNhanDBContext()
        {
        }

        public QuanLyBenhNhanDBContext(DbContextOptions<QuanLyBenhNhanDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M75UEQH\\SQLEXPRESS;Initial Catalog=QuanLyBenhNhanDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.HasKey(e => e.MaBn)
                    .HasName("PK__BenhNhan__272475ADDBFF7738");

                entity.ToTable("BenhNhan");

                entity.Property(e => e.MaBn)
                    .ValueGeneratedNever()
                    .HasColumnName("MaBN");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.VienPhi).HasColumnType("money");

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.BenhNhans)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("FK__BenhNhan__MaKhoa__267ABA7A");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__653904054B977363");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa).ValueGeneratedNever();

                entity.Property(e => e.TenKhoa).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
