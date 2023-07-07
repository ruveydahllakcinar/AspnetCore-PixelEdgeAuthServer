﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.ServicesLayer.Services
{
    public static class SignService
    {
        public static SecurityKey GetSymmetricSecurityKey(string securitykey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securitykey));
        }
    }
}
