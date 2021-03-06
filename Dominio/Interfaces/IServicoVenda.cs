using Dominio.Interfaces;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades.Interfaces
{
    public interface IServicoVenda : IServicoCRUD<Venda>
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
