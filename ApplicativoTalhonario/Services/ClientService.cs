using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using ApplicativoTalhonario.models;


namespace ApplicativoTalhonario.Services;

public class ClientService: IClientService
{
    private readonly IClientRepository repository;


    public ClientService(IClientRepository repository)
    {
        this.repository = repository;
    }

    public void saveCliente(ClientDto client)
    {
        
    }

    public Client findClientId(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteCliente(int id)
    {
        throw new NotImplementedException();
    }
}