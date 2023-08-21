using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataAccess.repositorio
{
    class EnderecoRepositorio : AbstractGeneric<Endereco>, IEnderecoRepositorio
    {
        ContextoDB ctx;
        public EnderecoRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }

        public Endereco ObterEnderecoPorIdCliente(int clienteID)
        {
            return ctx.Enderecos.FirstOrDefault(x => x.ClienteID.Equals(clienteID));
        }
    }
}
