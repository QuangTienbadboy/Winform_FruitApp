namespace FruitApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanQuanLy")]
    public partial class TaiKhoanQuanLy
    {
        [Key]
        [StringLength(10)]
        public string MaTaiKhoan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(40)]
        public string Username { get; set; }

        [Required]
        [StringLength(256)]
        public string MatKhau { get; set; }

        public bool Admin { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
