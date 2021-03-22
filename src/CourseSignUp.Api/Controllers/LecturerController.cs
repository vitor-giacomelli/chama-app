using System;
using System.Threading.Tasks;
using CourseSignUp.Services.DomainServices.Contracts;
using CourseSignUp.Services.Dto.Lecturers;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignUp.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class LecturersController : ControllerBase
    {
        ILecturerService _service;

        public LecturersController(ILecturerService service)
        {
            _service = service;
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Post([FromBody]LecturerDto createLecturerDto)
        {
            return Ok(await _service.CreateLecturer(createLecturerDto));
        }
    }
}