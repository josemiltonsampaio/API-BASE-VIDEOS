namespace VideoAPI.Models;
public class ClienteRepositorio
{
    public static List<Cliente> Clientes = new List<Cliente>
    {
        new Cliente
        {
            Id = 1,
            Nome = "Mariana"
        },
        new Cliente
        {
            Id = 2,
            Nome = "Mateus"
        }
    };
}
