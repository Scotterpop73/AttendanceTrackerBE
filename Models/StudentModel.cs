using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceTrackerBE.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public int seasonId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? seasonName { get; set; }
        public int dayAttended { get; set; }
        public int dayAbsent { get; set; }
        public int dayLate { get; set; }
        public int dayExcused { get; set; }
        public bool isDeleted { get; set; }
//         Student model
// ID
// Season ID
// Name
// Last Name
// Season Name
// Days Attended
// Days Absent
// Days Late
// Days excused
// isDeleted
    }
}