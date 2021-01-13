namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            Comments = new HashSet<Comment>();
            DatHangCTs = new HashSet<DatHangCT>();
            ThamGias = new HashSet<ThamGia>();
        }

        public int SachID { get; set; }

        [StringLength(150)]
        public string TenSach { get; set; }

        public double GiaBan { get; set; }

        [StringLength(5)]
        public string MaChuDe { get; set; }

        public int NhaXuatBanID { get; set; }

        public string MoTa { get; set; }

        [StringLength(50)]
        public string HinhBia { get; set; }

        public int SoTrang { get; set; }

        public int TrongLuong { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public int SoLanXem { get; set; }

        public int SoLuongBan { get; set; }

        public bool HetHang { get; set; }

        public virtual ChuDe ChuDe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHangCT> DatHangCTs { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThamGia> ThamGias { get; set; }
    }
}
