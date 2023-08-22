using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;

namespace ApiCliente.DataAccess.repositorio
{
    class EnderecoRepositorio : AbstractGeneric<Endereco>, IEnderecoRepositorio
    {
        ContextoDB ctx;
        public EnderecoRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }

        public List<Endereco> ObterEnderecoPorIdCliente(int clienteID)
        {
            return ctx.Enderecos.Where(x => x.ClienteID.Equals(clienteID)).ToList();
        }
    }
}
