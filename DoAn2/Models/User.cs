namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        public string TaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public bool TrangThai { get; set; }

        public int? RoleID { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
