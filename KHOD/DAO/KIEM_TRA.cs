namespace KHOD.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIEM_TRA
    {
        [Key]
        public int MaKT { get; set; }

        public int? MaNL { get; set; }

        public int? MaNV { get; set; }

        public DateTime? ThoiGian { get; set; }

        public int? MaLB { get; set; }

        public virtual DS_LOAI_BO_NL DS_LOAI_BO_NL { get; set; }

        public virtual NGUYEN_LIEU NGUYEN_LIEU { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
