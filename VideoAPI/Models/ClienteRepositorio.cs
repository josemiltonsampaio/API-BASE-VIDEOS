namespace VideoAPI.Models;
public class ClienteRepositorio
{
    private readonly AppDbContext _context;

    public ClienteRepositorio(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<Cliente> ObtemClientes()
    {
        return _context.Clientes;
    }
}
