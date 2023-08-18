using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.repositorio
{
    public interface IRepositorio
    {
        void SaveChanges();
        IClienteRepositorio Cliente { get; }
        IEnderecoRepositorio Endereco { get; }
    }
}
