namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DS_LOAI_BO_NL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DS_LOAI_BO_NL()
        {
            KIEM_TRA = new HashSet<KIEM_TRA>();
        }

        [Key]
        public int MaLB { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string LyDo { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEM_TRA> KIEM_TRA { get; set; }
    }
}
