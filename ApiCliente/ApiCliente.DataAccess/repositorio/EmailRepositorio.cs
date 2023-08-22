using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.modelo;
using ApiCliente.DataModel.repositorio;

namespace ApiCliente.DataAccess.repositorio
{
    class EmailRepositorio : AbstractGeneric<Email>, IEmailRepositorio
    {
        ContextoDB ctx;
        public EmailRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }

        public List<Email> ObterEmailPorCLienteID(int clienteID)
        {
            return ctx.Emails.Where(x => x.ClienteID.Equals(clienteID)).ToList();
        }
    }
}
