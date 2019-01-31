using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutyPlan.Entities
{
    public class LeaverMsg
    {
        public string Name { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public double Day { get; set; }
    }
}