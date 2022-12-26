namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAP_KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAP_KHO()
        {
            PHIEU_NHAP_KHO = new HashSet<PHIEU_NHAP_KHO>();
        }

        [Key]
        public int MaNK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public int? MaNV { get; set; }

        public int? MaHD { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_NHAP_KHO> PHIEU_NHAP_KHO { get; set; }
    }
}
