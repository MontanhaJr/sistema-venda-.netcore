using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using Repositorio.Interfaces;
using Repositorio.Repositorio;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Entidades
{
    public class RepositorioVenda : Repositorio<Venda>, IRepositorioVenda
    {
        public RepositorioVenda(ApplicationDbContext dbContext) : base(dbContext) { }

        public override void Delete(int id)
        {
            //Antes precisamos excluir os id's de venda que estão na tabla VendaProdutos

            var listaProdutos = DbSetContext.Include(x => x.Produtos)
                                            .Where(x => x.Codigo == id)
                                            .AsNoTracking()
                                            .ToList();

            foreach (var item in listaProdutos[0].Produtos)
            {
                VendaProdutos vendaProdutos = new VendaProdutos()
                {
                    CodigoVenda = id,
                    CodigoProduto = item.CodigoProduto
                };

                DbSet<VendaProdutos> DbSetAux;
                DbSetAux = Db.Set<VendaProdutos>();

                DbSetAux.Attach(vendaProdutos);
                DbSetAux.Remove(vendaProdutos);
                Db.SaveChanges();
            }

            

            base.Delete(id);
        }
    }
}
