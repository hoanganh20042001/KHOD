namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THONG_TIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONG_TIN()
        {
            DS_NGAY = new HashSet<DS_NGAY>();
        }

        public int Buoi { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int? QuanSo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TienAn { get; set; }

        [Key]
        public int MaTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DS_NGAY> DS_NGAY { get; set; }
    }
}
