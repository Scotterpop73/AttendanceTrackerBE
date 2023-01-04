using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceTrackerBE.Models
{
    public class SeasonModel
    {
        public int id { get; set; }
        public string? seasonName { get; set; }
        public bool isCurrent { get; set; }
        public bool isArchived { get; set; }
        
        SeasonModel(){}
    }
}