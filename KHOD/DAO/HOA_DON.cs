namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            NHAP_KHO = new HashSet<NHAP_KHO>();
        }

        [Key]
        public int MaHD { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        [StringLength(10)]
        public string MaGiaoDich { get; set; }

        public double? Thanhtien { get; set; }

        public int? MaDon { get; set; }

        public virtual DON_DAT_NL DON_DAT_NL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAP_KHO> NHAP_KHO { get; set; }
    }
}
