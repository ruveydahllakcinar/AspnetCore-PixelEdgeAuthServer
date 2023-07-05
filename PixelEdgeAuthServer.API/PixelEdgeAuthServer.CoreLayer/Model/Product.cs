using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.CoreLayer.Model
{
    public class Product
    {
        public int ProductId { get; set; }  //PK ataması yaaparken 3 yol bulunur. Bunlardan ilki Id'nin züerine [Key] yazmak
        //İkinci yol ise yukarıda gördüğünüz gibi sadece Id yada productId yazabilrisiniz.
        //Üçüncü yol ise Data katmanında oluşturduğumuz config ayarlarını yazdığımız yerde tanımlama yapmak.
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }
    }
}
