using Microsoft.AspNetCore.Mvc;
using PixelEdgeSharedLibrary.DTO;

namespace PixelEdgeAuthServer.API.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(Response<T>response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
