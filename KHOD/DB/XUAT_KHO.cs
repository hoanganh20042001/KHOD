namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XUAT_KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XUAT_KHO()
        {
            PHIEU_XUAT_KHO = new HashSet<PHIEU_XUAT_KHO>();
        }

        [Key]
        public int MaXK { get; set; }

        public DateTime? NgayXuat { get; set; }

        [StringLength(100)]
        public string LyDo { get; set; }

        public int? MaNV { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_XUAT_KHO> PHIEU_XUAT_KHO { get; set; }
    }
}
