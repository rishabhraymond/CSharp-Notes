using DITryAddMethod.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITryAddMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumerableValuesController : ControllerBase
    {
        private readonly IEnumerable<IDummyService> _dummyServices;

        public EnumerableValuesController(IEnumerable<IDummyService> dummyServices) 
        {
            _dummyServices = dummyServices;
        }

        [HttpGet]
        public IActionResult GetServiceTypes()
        {
            return Ok(_dummyServices.Select(service => service.GetType().Name));
        }
    }
}
