namespace FruitApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTaiKhoan { get; set; }

        public DateTime NgayDatHang { get; set; }

        public int ThanhTien { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChiGiaoHang { get; set; }

        public DateTime NgayGiaoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual TaiKhoanKhachHang TaiKhoanKhachHang { get; set; }
    }
}
