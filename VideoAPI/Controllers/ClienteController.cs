using Microsoft.AspNetCore.Mvc;
using VideoAPI.Models;

namespace VideoAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteRepositorio _repositorio;

    public ClienteController(ClienteRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet()]
    public IEnumerable<Cliente> ObtemClientes()
    {
        return _repositorio.ObtemClientes();
    }
}
