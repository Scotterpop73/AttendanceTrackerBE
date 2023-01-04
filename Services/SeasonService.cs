using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceTrackerBE.Models;
using AttendanceTrackerBE.Services.Context;

namespace AttendanceTrackerBE.Services
{
    public class SeasonService
    {
        private readonly DataContext context;

        public SeasonService(DataContext context)
        {
            _context = context;
        }

        public bool AddSeason(SeasonModel newSeason){
            _context.Add(newSeason);
            return _context.SaveChanges() != 0;
        }
    }
}