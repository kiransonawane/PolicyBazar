using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Quote.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {
        }
    }
}