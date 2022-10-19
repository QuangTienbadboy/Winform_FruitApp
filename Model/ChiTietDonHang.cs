namespace FruitApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaDonHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaTraiCay { get; set; }

        public int GiaBan { get; set; }

        public int SoLuong { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual TraiCay TraiCay { get; set; }
    }
}
