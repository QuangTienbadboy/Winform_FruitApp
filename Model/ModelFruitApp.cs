using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FruitApp.Model
{
    public partial class ModelFruitApp : DbContext
    {
        public ModelFruitApp()
            : base("name=ModelFruitApp")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DoiTac> DoiTacs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiTraiCay> LoaiTraiCays { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoanKhachHang> TaiKhoanKhachHangs { get; set; }
        public virtual DbSet<TaiKhoanQuanLy> TaiKhoanQuanLies { get; set; }
        public virtual DbSet<TraiCay> TraiCays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaTraiCay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoiTac>()
                .Property(e => e.MaDoiTac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoiTac>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoiTac>()
                .Property(e => e.Fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoiTac>()
                .Property(e => e.MaSoThue)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.TaiKhoanKhachHangs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiTraiCay>()
                .Property(e => e.MaLoaiTraiCay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTraiCay>()
                .HasMany(e => e.TraiCays)
                .WithRequired(e => e.LoaiTraiCay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoanQuanLies)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanKhachHang>()
                .Property(e => e.MaTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKhachHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKhachHang>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKhachHang>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.TaiKhoanKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanQuanLy>()
                .Property(e => e.MaTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanQuanLy>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanQuanLy>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanQuanLy>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TraiCay>()
                .Property(e => e.MaTraiCay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TraiCay>()
                .Property(e => e.MaLoaiTraiCay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TraiCay>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.TraiCay)
                .WillCascadeOnDelete(false);
        }
    }
}
