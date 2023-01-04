using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceTrackerBE.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceTrackerBE.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpPost]
    [Route("AddStudent")]
    public bool AddStudent(StudentModel item){
        return true;
    }
}
