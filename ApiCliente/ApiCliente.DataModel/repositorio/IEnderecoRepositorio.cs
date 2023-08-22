using ApiCliente.DataModel.modelo;

namespace ApiCliente.DataModel.repositorio
{
    public interface IEnderecoRepositorio : IRepositorioBase<Endereco>
    {
       List<Endereco> ObterEnderecoPorIdCliente(int clienteID);
    }
}
