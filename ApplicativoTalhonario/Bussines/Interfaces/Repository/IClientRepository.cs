using ApplicativoTalhonario.Bussines.Dtos;
using MySqlX.XDevAPI;

namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public interface IClientRepository
{
    public void saveClient(ClientDto client);
    
    public Client findById(int id);
    
    
    public void deleteClient(int id);
}