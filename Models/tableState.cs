namespace DutyPlan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tableState")]
    public partial class tableState
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(128)]
        public string DisplayName { get; set; }

        [StringLength(128)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public bool? Ext { get; set; }
    }
}
