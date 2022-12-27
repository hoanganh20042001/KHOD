namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAT_NL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAT_NL()
        {
            DON_DAT_NL = new HashSet<DON_DAT_NL>();
        }

        [Key]
        public int MaDat { get; set; }

        public int? MaTP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual THANH_PHAN THANH_PHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_DAT_NL> DON_DAT_NL { get; set; }
    }
}
