using CourseSignUp.Services.Dto.Courses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(new CourseDto
            {



            });
        }

        [HttpPost, Route("create")]
        public Task<IActionResult> Post([FromBody]CreateCourseDto createCourseDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("sign-up")]
        public Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            throw new NotImplementedException();

        }
    }
}
