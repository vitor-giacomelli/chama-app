using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class StatisticsController : ControllerBase
    {


        [HttpGet]
        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }
    }
}