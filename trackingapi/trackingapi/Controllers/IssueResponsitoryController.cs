using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using trackingapi.Models;
using trackingapi.Server;

namespace trackingapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueResponsitoryController : ControllerBase
    {
        private readonly IIssueResponsitory _issueResponsitory;

        public IssueResponsitoryController(IIssueResponsitory issueResponsitory)
        {
            _issueResponsitory = issueResponsitory;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_issueResponsitory.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult Add(Issue issue)
        {
            try
            {
                return Ok(_issueResponsitory.Add(issue));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
