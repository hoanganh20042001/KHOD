namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_XUAT_KHO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaXK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual NGUYEN_LIEU NGUYEN_LIEU { get; set; }

        public virtual XUAT_KHO XUAT_KHO { get; set; }
    }
}
