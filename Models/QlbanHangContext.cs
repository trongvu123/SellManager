using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

public partial class QlbanHangContext : DbContext
{
    public QlbanHangContext()
    {
    }

    public QlbanHangContext(DbContextOptions<QlbanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<ThanhPho> ThanhPhos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=QLBanHang;User ID=sa;Password=123456;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.Property(e => e.SoLuong).HasDefaultValue(1);

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHoaDons).HasConstraintName("FK_OrderDetails_Orders");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietHoaDons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Products");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK_Orders");

            entity.Property(e => e.NgayLapHd).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NgayNhanHang).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK_Customers");

            entity.Property(e => e.MaThanhPho).HasDefaultValue(1);

            entity.HasOne(d => d.MaThanhPhoNavigation).WithMany(p => p.KhachHangs).HasConstraintName("FK_KhachHang_ThanhPho");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK_Products");

            entity.Property(e => e.DonGia).HasDefaultValue(0.0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
