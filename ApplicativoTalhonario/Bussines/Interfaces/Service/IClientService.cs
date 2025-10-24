using ApplicativoTalhonario.Bussines.Dtos;
using MySqlX.XDevAPI;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IClientService
{
    public void saveCliente(ClientDto client);
    
    
    public Client findClientId(int id);
    
    public void DeleteCliente(int id);
}