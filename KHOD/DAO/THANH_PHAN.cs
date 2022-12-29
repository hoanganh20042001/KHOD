namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THANH_PHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THANH_PHAN()
        {
            DAT_NL = new HashSet<DAT_NL>();
            DS_TP = new HashSet<DS_TP>();
            NGUYEN_LIEU = new HashSet<NGUYEN_LIEU>();
        }

        [Key]
        public int MaTP { get; set; }

        [StringLength(50)]
        public string tenTP { get; set; }

        [StringLength(20)]
        public string DonViTinh { get; set; }

        public int? MaLoai { get; set; }

        public double? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAT_NL> DAT_NL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DS_TP> DS_TP { get; set; }

        public virtual LoaiNL LoaiNL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUYEN_LIEU> NGUYEN_LIEU { get; set; }
    }
}
