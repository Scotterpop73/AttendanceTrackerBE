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
        public DbSet<SeasonModel> SeasonInfo {get; set;}

        public DataContext(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var defaultData = new List<StudentModel>()
            {
                new StudentModel(){
                    id = 1,
                    seasonId = 1,
                    firstName = "Danny",
                    lastName = "Tran",
                    seasonName = "Best Season",
                    dayAttended = 100,
                    dayAbsent = 3,
                    dayLate = 20,
                    dayExcused = 0,
                    isDeleted = false
                },
                new StudentModel(){
                    id = 2,
                    seasonId = 1,
                    firstName = "Scott",
                    lastName = "Morenzone",
                    seasonName = "Best Season",
                    dayAttended = 103,
                    dayAbsent = 0,
                    dayLate = 1,
                    dayExcused = 3,
                    isDeleted = false
                },
                new StudentModel(){
                    id = 3,
                    seasonId = 1,
                    firstName = "Sophie",
                    lastName = "Espejo",
                    seasonName = "Best Season",
                    dayAttended = 103,
                    dayAbsent = 0,
                    dayLate = 0,
                    dayExcused = 0,
                    isDeleted = false
                },
                new StudentModel(){
                    id = 4,
                    seasonId = 2,
                    firstName = "Greg",
                    lastName = "McMc",
                    seasonName = "Season 5 Day School",
                    dayAttended = 103,
                    dayAbsent = 0,
                    dayLate = 0,
                    dayExcused = 0,
                    isDeleted = false
                },
            };
            builder.Entity<StudentModel>().HasData(defaultData);

            var SeasonData = new List<SeasonModel>(){
                new SeasonModel(){
                    id = 1,
                    seasonName = "Best Season",
                    isCurrent = false,
                    isArchived = true
                },
                new SeasonModel(){
                    id = 2,
                    seasonName = "Season 5 Day School",
                    isCurrent = false,
                    isArchived = true
                }
            };
            builder.Entity<SeasonModel>().HasData(SeasonData);
        }
    }

}
