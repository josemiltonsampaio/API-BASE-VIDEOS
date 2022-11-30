using Microsoft.AspNetCore.Mvc;
using VideoAPI.Models;

namespace VideoAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    [HttpGet()]
    public IEnumerable<Cliente> ObtemClientes()
    {
        return ClienteRepositorio.Clientes;
    }
}
