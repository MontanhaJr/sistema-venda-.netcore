using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
