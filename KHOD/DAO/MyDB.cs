using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KHOD.DAO
{
	public partial class MyDB : DbContext
	{
		public MyDB()
			: base("name=MyDB")
		{
		}

		public virtual DbSet<BO_PHAN> BO_PHAN { get; set; }
		public virtual DbSet<DAT_NL> DAT_NL { get; set; }
		public virtual DbSet<DON_DAT_NL> DON_DAT_NL { get; set; }
		public virtual DbSet<DS_LOAI_BO_NL> DS_LOAI_BO_NL { get; set; }
		public virtual DbSet<DS_NGAY> DS_NGAY { get; set; }
		public virtual DbSet<DS_TP> DS_TP { get; set; }
		public virtual DbSet<HOA_DON> HOA_DON { get; set; }
		public virtual DbSet<KIEM_TRA> KIEM_TRA { get; set; }
		public virtual DbSet<LICH_SU_DN> LICH_SU_DN { get; set; }
		public virtual DbSet<MON_AN> MON_AN { get; set; }
		public virtual DbSet<NGUYEN_LIEU> NGUYEN_LIEU { get; set; }
		public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
		public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
		public virtual DbSet<NHAP_KHO> NHAP_KHO { get; set; }
		public virtual DbSet<PHAN_QUYEN> PHAN_QUYEN { get; set; }
		public virtual DbSet<PHIEU_NHAP_KHO> PHIEU_NHAP_KHO { get; set; }
		public virtual DbSet<PHIEU_XUAT_KHO> PHIEU_XUAT_KHO { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<THANH_PHAN> THANH_PHAN { get; set; }
		public virtual DbSet<THONG_TIN> THONG_TIN { get; set; }
		public virtual DbSet<XUAT_KHO> XUAT_KHO { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<HOA_DON>()
				.Property(e => e.MaGiaoDich)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<MON_AN>()
				.HasMany(e => e.DS_TP)
				.WithRequired(e => e.MON_AN)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NGUYEN_LIEU>()
				.HasMany(e => e.PHIEU_NHAP_KHO)
				.WithRequired(e => e.NGUYEN_LIEU)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NGUYEN_LIEU>()
				.HasMany(e => e.PHIEU_XUAT_KHO)
				.WithRequired(e => e.NGUYEN_LIEU)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NHA_CUNG_CAP>()
				.Property(e => e.SDT)
				.HasPrecision(10, 0);

			modelBuilder.Entity<NHA_CUNG_CAP>()
				.Property(e => e.STK)
				.HasPrecision(13, 0);

			modelBuilder.Entity<NHAN_VIEN>()
				.Property(e => e.SDT)
				.HasPrecision(10, 0);

			modelBuilder.Entity<NHAN_VIEN>()
				.Property(e => e.TaiKhoan)
				.IsUnicode(false);

			modelBuilder.Entity<NHAN_VIEN>()
				.Property(e => e.MatKhau)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<NHAP_KHO>()
				.HasMany(e => e.PHIEU_NHAP_KHO)
				.WithRequired(e => e.NHAP_KHO)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<THANH_PHAN>()
				.HasMany(e => e.DS_TP)
				.WithRequired(e => e.THANH_PHAN)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<THONG_TIN>()
				.Property(e => e.TienAn)
				.HasPrecision(6, 0);

			modelBuilder.Entity<XUAT_KHO>()
				.HasMany(e => e.PHIEU_XUAT_KHO)
				.WithRequired(e => e.XUAT_KHO)
				.WillCascadeOnDelete(false);
		}
	}
}
