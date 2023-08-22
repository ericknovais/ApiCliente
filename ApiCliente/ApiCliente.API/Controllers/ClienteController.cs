using ApiCliente.AppWeb.ViwmModels;
using ApiCliente.DataAccess.repositorio;
using ApiCliente.DataModel.modelo;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        Repositorio repositorio = new Repositorio();
        [HttpGet("GetClientes")]
        public List<ClienteViewModel> Cliente()
        {
            try
            {
                return ObterClientesViewModel();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<ClienteViewModel> ObterClientesViewModel()
        {
            List<ClienteViewModel> ListaCLientes = new List<ClienteViewModel>();

            var clientes = repositorio.Cliente.ObterTodos();
            var cliente = new Cliente();
            foreach (var cli in clientes)
            {
                var clienteModel = new ClienteViewModel();
                cliente = repositorio.Cliente.ObterPorID(cli.ID);
                
                clienteModel.ID = cliente.ID;
                clienteModel.NomeCompleto = cliente.NomeCompleto;
                clienteModel.Telefone = cliente.Telefone;

                var email = repositorio.Email.ObterEmailPorCLienteID(cli.ID).FirstOrDefault(x => x.Principal.Equals(true));
                var endereco = repositorio.Endereco.ObterEnderecoPorIdCliente(cli.ID).FirstOrDefault(x => x.Principal.Equals(true));

                clienteModel.Emails.ID = email.ID;
                clienteModel.Emails.Email = email.Descricao;
                clienteModel.Emails.Principal = email.Principal;

                clienteModel.Enderecos.ID = endereco.ID;
                clienteModel.Enderecos.CEP = endereco.CEP;
                clienteModel.Enderecos.Logradouro = endereco.Logradouro;
                clienteModel.Enderecos.Numero = endereco.Numero;
                clienteModel.Enderecos.Complemento = endereco.Complemento;
                clienteModel.Enderecos.Bairro = endereco.Bairro;
                clienteModel.Enderecos.Cidade = endereco.Cidade;
                clienteModel.Enderecos.Estado = endereco.Estado;
                clienteModel.Enderecos.Principal = endereco.Principal;

                ListaCLientes.Add(clienteModel);
            }
            return ListaCLientes;
        }
    }
}
