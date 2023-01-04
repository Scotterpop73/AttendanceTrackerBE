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
    //private readonly SeasonService _data
    
    //public SeasonController(SeasonService dataFromService)
    //{
        //_data = dataFromService;
    //}


    [HttpPost]
    [Route("AddSeason")]
    public bool AddSeason(SeasonModel item){
        return true;
        //return _data.AddSeason(item);
    }

    [HttpGet]
    [Route("GetSeason")]
    public SeasonModel GetSeason(SeasonModel item){
        return item;
    }
}
