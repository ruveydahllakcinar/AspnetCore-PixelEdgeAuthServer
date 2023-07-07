using Microsoft.AspNetCore.Identity;
using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeAuthServer.CoreLayer.Model;
using PixelEdgeAuthServer.CoreLayer.Services;
using PixelEdgeSharedLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.ServicesLayer.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
           var user =new AppUser { Email = createUserDto.Email, UserName=createUserDto.Username };

            var result = await _userManager.CreateAsync(user,createUserDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return Response<AppUserDto>.Fail(new ErrorDto(errors, true), 400);
            }

            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }

        public async Task<Response<AppUserDto>> GetUserByNameAsync(string Username)
        {
           var user =await _userManager.FindByNameAsync(Username); 
            if (user == null)
            {
                return Response<AppUserDto>.Fail("Username not found",404,true);
            }

            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }
    }
}
