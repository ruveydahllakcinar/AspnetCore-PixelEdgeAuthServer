using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.DTOs
{
    public class TokenDto
    {
      
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpressionDate { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpirationDate { get; set; }

    }
}
