namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserKH")]
    public partial class UserKH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserKH()
        {
            Comments = new HashSet<Comment>();
        }

        public int ID { get; set; }

        public string TaiKhoan { get; set; }

        public string PassWord { get; set; }

        public string ConfirmPassword { get; set; }

        public string Ten { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public string Email { get; set; }

        public string DienThoai { get; set; }

        [StringLength(50)]
        public string TinhThanh { get; set; }

        [StringLength(50)]
        public string QuanHuyen { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(50)]
        public string Hinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
