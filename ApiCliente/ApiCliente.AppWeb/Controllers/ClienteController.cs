using ApiCliente.AppWeb.ViwmModels;
using ApiCliente.DataAccess.repositorio;
using ApiCliente.DataModel.modelo;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.AppWeb.Controllers
{
    public class ClienteController : Controller
    {
        #region Repositorio
        Repositorio repositorio = new Repositorio();
        #endregion

        public IActionResult List()
        {
            try
            {
                return View(repositorio.Cliente.ObterTodos());
            }
            catch (Exception ex)
            {
                return View(new List<Cliente>());
            }
        }

        public IActionResult Edit(int id = 0)
        {
            try
            {
                return View(id.Equals(0) ? new ClienteViewModel() : ObterClienteViewModel(id));
            }
            catch (Exception ex)
            {
                return View(new ClienteViewModel());
            }
        }

        [HttpPost]
        public IActionResult Edit(ClienteViewModel clienteView, int id = 0)
        {
            try
            {
                Cliente cliente = ObterCliente(id);
                cliente.NomeCompleto = clienteView.NomeCompleto;
                cliente.Email = clienteView.Email;
                cliente.Telefone = clienteView.Telefone;
                cliente.DataCriacao = id.Equals(0) ? DateTime.Now : cliente.DataCriacao;
                cliente.DataAtualizacao = DateTime.Now;
                cliente.Validar();
                repositorio.Cliente.Salvar(cliente);

                Endereco endereco = ObterEnderecoCliente(cliente.ID);
                endereco.ClienteID = cliente.ID;
                endereco.CEP = clienteView.CEP;
                endereco.Logradouro = clienteView.Logradouro;
                endereco.Bairro = clienteView.Bairro;
                endereco.Numero = clienteView.Numero;
                endereco.Complemento = clienteView.Complemento;
                endereco.Cidade = clienteView.Cidade;
                endereco.Estado = clienteView.Estado;
                endereco.DataCriacao = id.Equals(0) ? DateTime.Now : endereco.DataCriacao;
                endereco.DataAtualizacao = DateTime.Now;
                endereco.Validar();
                repositorio.Endereco.Salvar(endereco);

                repositorio.SaveChanges();

                if (id.Equals(0))
                    ModelState.Clear();

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                return View(new ClienteViewModel());
            }
        }
        private ClienteViewModel ObterClienteViewModel(int id)
        {
            Cliente cliente = ObterCliente(id);
            Endereco endereco = ObterEnderecoCliente(cliente.ID);

            ClienteViewModel clienteView = new ClienteViewModel()
            {
                NomeCompleto = cliente.NomeCompleto,
                Telefone = cliente.Telefone,
                Email = cliente.Email,
                CEP = endereco.CEP,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado
            };

            return clienteView;
        }
        private Cliente ObterCliente(int id)
        {
            return !id.Equals(0) ? repositorio.Cliente.ObterPorID(id) : new Cliente();
        }
        private Endereco ObterEnderecoCliente(int clienteID)
        {
            return clienteID.Equals(0) ? new Endereco() : repositorio.Endereco.ObterEnderecoPorIdCliente(clienteID);
        }
    }
}
