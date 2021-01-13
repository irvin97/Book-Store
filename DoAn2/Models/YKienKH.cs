namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YKienKH")]
    public partial class YKienKH
    {
        [Key]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [MaxLength(50)]
        public byte[] SDT { get; set; }

        public string DiaChi { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGui { get; set; }

        public long? KHID { get; set; }
    }
}
