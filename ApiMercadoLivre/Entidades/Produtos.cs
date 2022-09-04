using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMercadoLivre.Entidades
{
    public class Produtos
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Initial_quantity { get; set; }
        public string Available_quantity { get; set; }
        public string Thumbnail { get; set; }
        public string Secure_thumbnail { get; set; }
        public DateTime Horario { get; set; }
        public string Status { get; set; }

    }
}
