using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutyPlan.Entities
{
    public class LeaverSave
    {
        public string uid { get; set; }

        public string displayName { get; set; }

        public int day { get; set; }

        public string report { get; set; }

        public DateTime startTime { get; set; }
    }
}