namespace FruitApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiTac")]
    public partial class DoiTac
    {
        [Key]
        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDoiTac { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChiDoiTac { get; set; }

        [Required]
        [StringLength(10)]
        public string DienThoai { get; set; }

        public DateTime NgayHopTac { get; set; }

        [StringLength(15)]
        public string Fax { get; set; }

        [StringLength(15)]
        public string MaSoThue { get; set; }

        [StringLength(256)]
        public string MoTa { get; set; }
    }
}
