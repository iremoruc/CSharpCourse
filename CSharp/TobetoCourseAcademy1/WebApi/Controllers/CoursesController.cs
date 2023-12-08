using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _courseService.GetListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Course course)
        {
            
            return Ok();
        }
    }
}
