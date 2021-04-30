using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class RelatorioController : Controller
    {
        protected ApplicationDbContext mContext;

        public RelatorioController(ApplicationDbContext context)
        {
            mContext = context;
        }
        
        public IActionResult Grafico()
        {
            var lista = (from r in mContext.VendaProdutos
                         group r by new { r.CodigoProduto, r.Produto.Descricao }
                   into g
                         select new GraficoViewModel
                         {
                             CodigoProduto = g.Key.CodigoProduto,
                             Descricao = g.Key.Descricao,
                             TotalVendido = g.Sum(x => x.Quantidade)
                         }).ToList();

            string valores = string.Empty;
            string labels = string.Empty;
            string cores = string.Empty;

            var random = new Random();

            foreach (var item in lista)
            {
                valores += "'" + item.TotalVendido.ToString() + "',";
                labels += "'" + item.Descricao.ToString() + "',";
                cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000) + "',");
            }

            ViewBag.Valores = valores;
            ViewBag.Labels = labels;
            ViewBag.Cores = cores;

            return View();
        }
    }
}
