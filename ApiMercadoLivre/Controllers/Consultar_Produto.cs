using ApiMercadoLivre.Entidades;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiMercadoLivre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Consultar_Produto : Controller
    {
        Servico servico = new();
      
        [HttpGet]
        public async Task<Produtos> ConsultaProduto(string idProduto)
        {
            
            var produto = await servico.MontaProduto(idProduto);
            servico.SalvaLog(produto);
            return produto;
        }
    }
}
