using PixelEdgeAuthServer.CoreLayer.Configurations;
using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeAuthServer.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}
