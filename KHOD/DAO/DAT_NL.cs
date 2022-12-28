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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public int? MaDon { get; set; }

        public virtual DON_DAT_NL DON_DAT_NL { get; set; }
    }
}
