using ApiCliente.DataAccess.db;
using ApiCliente.DataModel.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
