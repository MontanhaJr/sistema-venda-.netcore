using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorio
{
    public interface IRepositorioVendaProdutos
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
