namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIEM_TRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KIEM_TRA()
        {
            DS_LOAI_BO_NL = new HashSet<DS_LOAI_BO_NL>();
        }

        [Key]
        public int MaKT { get; set; }

        public int? MaNL { get; set; }

        public int? MaNV { get; set; }

        public DateTime? ThoiGian { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DS_LOAI_BO_NL> DS_LOAI_BO_NL { get; set; }

        public virtual NGUYEN_LIEU NGUYEN_LIEU { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
