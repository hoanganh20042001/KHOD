namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DS_LOAI_BO_NL
    {
        [Key]
        public int MaLB { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string LyDo { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? MaKT { get; set; }

        public virtual KIEM_TRA KIEM_TRA { get; set; }
    }
}
