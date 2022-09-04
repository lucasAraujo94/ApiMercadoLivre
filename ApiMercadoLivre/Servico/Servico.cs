using ApiMercadoLivre.Entidades;
using DocumentFormat.OpenXml.ExtendedProperties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiMercadoLivre
{
    public class Servico
    {
        static HttpClient client = new();
        public async Task<string> AcessoApiML(string idProduto)
        { 
            var response = await client.GetAsync($"https://api.mercadolibre.com/items/{idProduto}/?include_attributes=all");
            return await response.Content.ReadAsStringAsync();   
        }
        public async Task <Produtos> MontaProduto (string idProduto) 
        {
            Produtos produto = JsonConvert.DeserializeObject<Produtos>(await AcessoApiML(idProduto));
            produto.Horario = DateTime.Now;
            return produto;
        }

        public bool SalvaLog(Produtos produto)
        {
            try
            {
                var lines = $"{produto.Title} - {produto.Status} - {produto.Horario}  ";
                var arquivo = System.IO.File.AppendText("Logs/log_consulta_produto.txt");
                arquivo.WriteLine(lines);
                arquivo.Close();
                return true;
            }
            catch 
            {
                return false; 
            }           

        }
    }
}
