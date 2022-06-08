using DIAddMethod.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIAddMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDummyService _dummyService;

        public ValuesController(IDummyService dummyService)
        {
            _dummyService = dummyService;
        }

        [HttpGet]
        public IActionResult GetServiceType()
        {
            return Ok(_dummyService.GetType().Name);
        }
    }
}
