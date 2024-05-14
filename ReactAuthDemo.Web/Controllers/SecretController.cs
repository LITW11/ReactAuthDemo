using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactAuthDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        [HttpGet("getdata")]
        [Authorize]
        public object GetData()
        {
            //Console.WriteLine(User.Identity.Name); //gets currently logged in users email
            return new { number = new Random().Next(1, 10000) };
        }
    }
}
