using Microsoft.AspNetCore.Mvc;

namespace AbpCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : AbpCoreController
    {
        [HttpGet]
        public string HelloWorld()
        {
            return "Helloworld";
        }
    }
}
