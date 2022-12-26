namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_NHAP_KHO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string GHiChu { get; set; }

        public virtual NGUYEN_LIEU NGUYEN_LIEU { get; set; }

        public virtual NHAP_KHO NHAP_KHO { get; set; }
    }
}
