namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThamGia")]
    public partial class ThamGia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SachID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TacGiaID { get; set; }

        [StringLength(100)]
        public string VaiTro { get; set; }

        public int ViTri { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
