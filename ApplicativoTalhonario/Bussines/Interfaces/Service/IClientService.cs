using MySqlX.XDevAPI;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IClientService
{
    public void CreateCliente(Client client);
    
    public void UpdateCliente(Client client);
    
    public Client findClientId(int id);
    
    public void DeleteCliente(int id);
}