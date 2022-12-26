namespace KHOD.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LICH_SU_DN
    {
        [Key]
        public int MaLS { get; set; }

        public int? MaNV { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(100)]
        public string HoatDong { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
