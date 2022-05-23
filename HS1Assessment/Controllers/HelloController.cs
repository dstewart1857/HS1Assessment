using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HS1Assessment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet(Name = "hello")]
        [SwaggerOperation(Summary = "-- Will return a hello message using the provided name.")]
        public String HelloWorld(String name)
        {
            return "Hello " + name + ",\n\nHave a GREAT DAY!!!";
        }
    }
}
