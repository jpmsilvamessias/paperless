using MySqlX.XDevAPI;

namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public interface IClientRepository
{
    public void saveClient(Client client);
    
    public Client findById(int id);
    
    public void updateClient(int id);
    
    public void deleteClient(int id);
}