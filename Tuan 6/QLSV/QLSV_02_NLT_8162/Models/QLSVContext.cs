using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLSV_02_NLT_8162.Models
{
    public partial class QLSVContext : DbContext
    {
        public QLSVContext()
        {
        }

        public QLSVContext(DbContextOptions<QLSVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KhoaTt> KhoaTts { get; set; }
        public virtual DbSet<Sv> Svs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M75UEQH\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<KhoaTt>(entity =>
            {
                entity.HasKey(e => e.MaKtt)
                    .HasName("PK__KhoaTT__26DC9042F02EA98C");

                entity.ToTable("KhoaTT");

                entity.Property(e => e.MaKtt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("maKtt")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKtt)
                    .HasMaxLength(50)
                    .HasColumnName("tenKtt");
            });

            modelBuilder.Entity<Sv>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SV__7A227A44217554D5");

                entity.ToTable("SV");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("maSv")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKtt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("maKtt")
                    .IsFixedLength(true);

                entity.Property(e => e.SoLanXs).HasColumnName("soLanXs");

                entity.Property(e => e.TenSv)
                    .HasMaxLength(50)
                    .HasColumnName("tenSv");

                entity.Property(e => e.TienThuong)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tienThuong")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaKttNavigation)
                    .WithMany(p => p.Svs)
                    .HasForeignKey(d => d.MaKtt)
                    .HasConstraintName("FK__SV__maKtt__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
