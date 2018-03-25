namespace Praise2017.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Descrip { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ToWho { get; set; }

        [StringLength(10)]
        public string UpdateId { get; set; }

       // public int Month { get; set; }
    }
}
