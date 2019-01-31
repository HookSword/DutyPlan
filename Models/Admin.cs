using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DutyPlan.Models
{
    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}