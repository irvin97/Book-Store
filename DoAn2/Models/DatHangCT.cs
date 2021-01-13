namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHangCT")]
    public partial class DatHangCT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DatHangID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SachID { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        public double ThanhTien { get; set; }

        public virtual DatHang DatHang { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
