using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppDataBaseConnection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        // GET: NameController
        [HttpGet]
        public string GetMyName()
        {
            return "Marco Astudillo";
        }        
         
    }
}
