using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeSharedLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Services
{
    public interface IUserService
    {
        Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<AppUserDto>> GetUserByNameAsync(string username);
    }
}
