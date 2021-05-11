using Aplicacao.Servico.Interfaces;
using Dominio.Entidades.Interfaces;
using Dominio.Servicos;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoUsuario : IServicoAplicacaoUsuario
    {
        private IServicoUsuario ServicoUsuario;

        public ServicoAplicacaoUsuario(IServicoUsuario servicoUsuario)
        {
            ServicoUsuario = servicoUsuario;
        }

        public Usuario RetornarDadosUsuario(string email, string senha)
        {
            return ServicoUsuario.Listagem().Where(x => x.Email == email && x.Senha.ToUpper() == senha.ToUpper()).FirstOrDefault();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return ServicoUsuario.ValidarLogin(email, senha);
        }
    }
}
