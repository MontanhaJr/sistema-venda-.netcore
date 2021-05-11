using Dominio.Interfaces;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades.Interfaces
{
    public interface IServicoUsuario : IServicoCRUD<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
