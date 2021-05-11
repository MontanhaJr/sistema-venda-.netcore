﻿using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorio
{
    public interface IRepositorioVenda : IRepositorio<Venda>
    {
        new void Delete(int id);
    }
}
