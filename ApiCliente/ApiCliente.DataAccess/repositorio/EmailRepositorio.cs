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
