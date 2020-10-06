using Microsoft.AspNetCore.Mvc;

namespace NEWPROJECT_CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
