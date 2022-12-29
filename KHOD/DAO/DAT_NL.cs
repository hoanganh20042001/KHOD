namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAT_NL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDon { get; set; }

        public virtual DON_DAT_NL DON_DAT_NL { get; set; }

        public virtual THANH_PHAN THANH_PHAN { get; set; }
    }
}
