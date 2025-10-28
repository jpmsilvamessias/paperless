using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IClientService
{
    public void saveCliente(ClientDto dto);
    
    
    public Client findClientId(long id);
    
    public void DeleteCliente(long id);
}