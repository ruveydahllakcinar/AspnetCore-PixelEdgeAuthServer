using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeAuthServer.CoreLayer.Services;
using PixelEdgeAuthServer.ServicesLayer.Services;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
    public async Task<IActionResult> CreateTokenAsync(LoginDto loginDto)
        {
            var result = await _authenticationService.CreateToken(loginDto);
            result.Success = true;
        }
    }
}
