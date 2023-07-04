﻿using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeSharedLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateToken(LoginDto loginDto);

        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken); 

        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientTokenDto clientTokenDto);
    }
}
