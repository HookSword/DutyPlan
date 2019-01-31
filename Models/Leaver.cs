namespace DutyPlan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Leaver")]
    public partial class Leaver
    {
        [Key]
        [StringLength(50)]
        public string Uid { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public double? Day { get; set; }

        public string Report { get; set; }

        public DateTime? StartTime { get; set; }
    }
}
