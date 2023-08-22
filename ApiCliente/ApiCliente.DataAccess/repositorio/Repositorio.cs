using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.repositorio;

namespace ApiCliente.DataAccess.repositorio
{
    public class Repositorio : IRepositorio
    {
        ContextoDB ctx;

        public Repositorio()
        {
            ctx = new ContextoDB();
        }

        IClienteRepositorio cliente;
        public IClienteRepositorio Cliente { get { return cliente ?? (cliente = new ClienteRepositorio(ctx)); } }

        IEnderecoRepositorio endereco;
        public IEnderecoRepositorio Endereco { get { return endereco ?? (endereco = new EnderecoRepositorio(ctx)); } }

        IEmailRepositorio email;
        public IEmailRepositorio Email { get { return email ?? (email = new EmailRepositorio(ctx)); } }


        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
