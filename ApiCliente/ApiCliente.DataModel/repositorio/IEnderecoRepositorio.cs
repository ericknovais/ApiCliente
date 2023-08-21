using ApiCliente.DataModel.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.DataModel.repositorio
{
    public interface IEnderecoRepositorio : IRepositorioBase<Endereco>
    {
        Endereco ObterEnderecoPorIdCliente(int clienteID);
    }
}
