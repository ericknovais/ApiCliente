using ApiCliente.DataAccess.repositorio;
using ApiCliente.DataModel.modelo;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.API.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class ClienteController
    {
        Repositorio repositorio = new Repositorio();
        [HttpGet("GetClientes")]
        public List<Cliente> Cliente() 
        {
            try
            {
                var lista = repositorio.Cliente.ObterTodos();
                return lista.ToList();
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}
