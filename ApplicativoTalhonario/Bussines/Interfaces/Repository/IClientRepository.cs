using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;


namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public interface IClientRepository
{
    public void saveClient(Client client);
    
    public Client findById(long id);
    
    
    public void deleteClient(long id);
}