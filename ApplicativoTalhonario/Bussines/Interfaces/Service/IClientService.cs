using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IClientService
{
    public void saveCliente(ClientDto client);
    
    
    public Client findClientId(int id);
    
    public void DeleteCliente(int id);
}