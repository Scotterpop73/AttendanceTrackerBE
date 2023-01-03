using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceTrackerBE.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceTrackerBE.Controllers;

[ApiController]
[Route("[controller]")]
public class SeasonController : ControllerBase
{
    [HttpPost]
    [Route("AddSeason")]
    public bool AddSeason(SeasonModel item){
        return true;
    }
}
