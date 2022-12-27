namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DS_NGAY
    {
        [Key]
        public int MaN { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int? MaTT { get; set; }

        public virtual THONG_TIN THONG_TIN { get; set; }
    }
}
