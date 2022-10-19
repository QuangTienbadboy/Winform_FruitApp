namespace FruitApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTraiCay")]
    public partial class LoaiTraiCay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiTraiCay()
        {
            TraiCays = new HashSet<TraiCay>();
        }

        [Key]
        [StringLength(6)]
        public string MaLoaiTraiCay { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiTraiCay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraiCay> TraiCays { get; set; }
    }
}
