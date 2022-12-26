namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            DON_DAT_NL = new HashSet<DON_DAT_NL>();
            KIEM_TRA = new HashSet<KIEM_TRA>();
            LICH_SU_DN = new HashSet<LICH_SU_DN>();
            NHAP_KHO = new HashSet<NHAP_KHO>();
            XUAT_KHO = new HashSet<XUAT_KHO>();
        }

        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(10)]
        public string TenNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDT { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(20)]
        public string QuanHam { get; set; }

        [StringLength(20)]
        public string TaiKhoan { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCN { get; set; }

        public int? MaBP { get; set; }

        public int? MaPQ { get; set; }

        public bool? TrangThai { get; set; }

        public virtual BO_PHAN BO_PHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_DAT_NL> DON_DAT_NL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEM_TRA> KIEM_TRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICH_SU_DN> LICH_SU_DN { get; set; }

        public virtual PHAN_QUYEN PHAN_QUYEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAP_KHO> NHAP_KHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUAT_KHO> XUAT_KHO { get; set; }
    }
}
