namespace FruitApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraiCay")]
    public partial class TraiCay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraiCay()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(6)]
        public string MaTraiCay { get; set; }

        [Required]
        [StringLength(6)]
        public string MaLoaiTraiCay { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTraiCay { get; set; }

        [Required]
        [StringLength(30)]
        public string ThoiGianBaoQuan { get; set; }

        [Required]
        [StringLength(30)]
        public string DonViTinh { get; set; }

        public int GiaBan { get; set; }

        public int GiaMua { get; set; }

        [Required]
        [StringLength(256)]
        public string HinhAnh { get; set; }

        [Required]
        [StringLength(512)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual LoaiTraiCay LoaiTraiCay { get; set; }
    }
}
