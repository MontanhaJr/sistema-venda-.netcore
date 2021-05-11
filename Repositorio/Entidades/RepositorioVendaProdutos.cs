using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using Repositorio.Repositorio;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Entidades
{
    public class RepositorioVendaProdutos : IRepositorioVendaProdutos
    {
        protected ApplicationDbContext DbSetContext;
        public RepositorioVendaProdutos(ApplicationDbContext mContext)
        {
            DbSetContext = mContext;
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            var lista = (from r in DbSetContext.VendaProdutos.Include(x => x.Produto)
                         group r by new { r.CodigoProduto, r.Produto.Descricao}
                         into g
                         select new GraficoViewModel
                         {
                             CodigoProduto = g.Key.CodigoProduto,
                             Descricao = g.Key.Descricao,
                             TotalVendido = g.Sum(z => z.Quantidade)
                         }).ToList();

            return lista;
        }
    }
}
