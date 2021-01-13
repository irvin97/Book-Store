namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SlideBar")]
    public partial class SlideBar
    {
        [Key]
        public int SlideID { get; set; }

        [StringLength(50)]
        public string Hinh { get; set; }
    }
}
