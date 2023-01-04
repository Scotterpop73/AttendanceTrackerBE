using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceTrackerBE.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceTrackerBE.Services.Context
{
    public class DataContext: DbContext
    {
        public DbSet<StudentModel> StudentInfo {get; set;}
    }
}