using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;


namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public interface IClientRepository
{
    public void saveClient(Client client);
    
    public Client findById(int id);
    
    
    public void deleteClient(int id);
}