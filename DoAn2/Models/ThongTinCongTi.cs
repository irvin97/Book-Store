namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinCongTi")]
    public partial class ThongTinCongTi
    {
        [Key]
        [StringLength(50)]
        public string TenCongTi { get; set; }

        public string TruSo { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Logo { get; set; }
    }
}
