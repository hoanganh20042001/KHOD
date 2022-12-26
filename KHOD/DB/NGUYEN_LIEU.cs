namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NGUYEN_LIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYEN_LIEU()
        {
            KIEM_TRA = new HashSet<KIEM_TRA>();
            PHIEU_NHAP_KHO = new HashSet<PHIEU_NHAP_KHO>();
            PHIEU_XUAT_KHO = new HashSet<PHIEU_XUAT_KHO>();
        }

        [Key]
        public int MaNL { get; set; }

        [StringLength(50)]
        public string TenNL { get; set; }

        public double? DonGia { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public DateTime NgaySanXuat { get; set; }

        public DateTime? HanSuDung { get; set; }

        public int? SoLuong { get; set; }

        public bool? TrangThai { get; set; }

        public int? MaTP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEM_TRA> KIEM_TRA { get; set; }

        public virtual THANH_PHAN THANH_PHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_NHAP_KHO> PHIEU_NHAP_KHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_XUAT_KHO> PHIEU_XUAT_KHO { get; set; }
    }
}
