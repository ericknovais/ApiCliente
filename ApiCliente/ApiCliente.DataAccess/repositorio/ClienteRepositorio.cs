using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;

namespace ApiCliente.DataAccess.repositorio
{
    class ClienteRepositorio : AbstractGeneric<Cliente>, IClienteRepositorio
    {
        ContextoDB ctx;
        public ClienteRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }
    }
}
