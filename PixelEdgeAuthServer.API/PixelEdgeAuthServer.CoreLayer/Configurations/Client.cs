using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Configurations
{
    public class Client
    {
        public string ClientId { get; set; }

        public string Secret { get; set; }

        public List<String> Audiences { get; set; }
    }
}
