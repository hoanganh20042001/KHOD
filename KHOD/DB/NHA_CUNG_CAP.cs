namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHA_CUNG_CAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHA_CUNG_CAP()
        {
            DON_DAT_NL = new HashSet<DON_DAT_NL>();
        }

        [Key]
        public int MaNCC { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_DAT_NL> DON_DAT_NL { get; set; }
    }
}
