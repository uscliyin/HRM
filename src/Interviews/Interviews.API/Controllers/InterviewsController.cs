using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interviews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [Authorize]
        public IActionResult GetAllInterviews()
        {

            var interviews = new List<string>(
                new[] { "abc,xyz,dddd" }

                ); ;
            return Ok( interviews );

        }
    }
}
