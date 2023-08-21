using ApiCliente.AppWeb.ViwmModels;
using ApiCliente.DataAccess.repositorio;
using ApiCliente.DataModel.modelo;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

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
                cliente.Telefone = clienteView.Telefone;
                cliente.DataCriacao = id.Equals(0) ? DateTime.Now : cliente.DataCriacao;
                cliente.DataAtualizacao = DateTime.Now;
                cliente.Validar();
                repositorio.Cliente.Salvar(cliente);

                List<Email> emails = cliente.ID.Equals(0) ? new List<Email>() : repositorio.Email.ObterEmailPorCLienteID(cliente.ID);

                var x = 0;

                foreach (var item in clienteView.Emails)
                {
                    Email email = id.Equals(0) ? new Email() : repositorio.Email.ObterPorID(item.ID);
                    email.ClienteID = cliente.ID;
                    email.Descricao = item.Descricao;
                    email.DataCriacao = id.Equals(0) ? DateTime.Now : email.DataCriacao;
                    email.DataAtualizacao = DateTime.Now;
                    if (x.Equals(0))
                        email.Principal = true;
                    else
                        email.Principal = false;
                    email.Validar();
                    repositorio.Email.Salvar(email);
                    x++;
                }

                List<Endereco> enderecos = ObterEnderecoCliente(cliente.ID);

                x = 0;
                foreach (var item in clienteView.Enderecos)
                {
                    Endereco endereco = id.Equals(0) ? new Endereco() : repositorio.Endereco.ObterPorID(item.ID);
                    endereco.ClienteID = cliente.ID;
                    endereco.CEP = item.CEP;
                    endereco.Logradouro = item.Logradouro;
                    endereco.Bairro = item.Bairro;
                    endereco.Numero = item.Numero;
                    endereco.Complemento = item.Complemento;
                    endereco.Cidade = item.Cidade;
                    endereco.Estado = item.Estado;
                    endereco.DataCriacao = id.Equals(0) ? DateTime.Now : endereco.DataCriacao;
                    endereco.DataAtualizacao = DateTime.Now;
                    if (x.Equals(0))
                        endereco.Principal = true;
                    else
                        endereco.Principal = false;
                    enderecos.Add(endereco);
                    endereco.Validar();
                    repositorio.Endereco.Salvar(endereco);
                    x++;
                }

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
            List<Endereco> enderecos = ObterEnderecoCliente(cliente.ID);
            List<Email> emails = repositorio.Email.ObterEmailPorCLienteID(cliente.ID);

            ClienteViewModel clienteView = new ClienteViewModel()
            {
                NomeCompleto = cliente.NomeCompleto,
                Telefone = cliente.Telefone,
                Emails = emails,
                Enderecos = enderecos
            };

            return clienteView;
        }
        private Cliente ObterCliente(int id)
        {
            return !id.Equals(0) ? repositorio.Cliente.ObterPorID(id) : new Cliente();
        }
        private List<Endereco> ObterEnderecoCliente(int clienteID)
        {
            return clienteID.Equals(0) ? new List<Endereco>() : repositorio.Endereco.ObterEnderecoPorIdCliente(clienteID);
        }
    }
}
