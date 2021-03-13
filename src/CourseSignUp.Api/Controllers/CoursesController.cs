using CourseSignUp.Services.DomainServices.Contracts;
using CourseSignUp.Services.Dto.Courses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        ICoursesService _service;
        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        [HttpGet, Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetCourseById(id));
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Post([FromBody]CreateCourseDto createCourseDto)
        {
            return Ok(await _service.CreateCourse(createCourseDto));
            
        }

        [HttpPost, Route("sign-up")]
        public Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            throw new NotImplementedException();

        }
    }
}
