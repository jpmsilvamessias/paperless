using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using MySqlX.XDevAPI;

namespace ApplicativoTalhonario.Services;

public class ClientService: IClientService
{
    private readonly IClientRepository repository;


    public ClientService(IClientRepository repository)
    {
        this.repository = repository;
    }


    public void CreateCliente(Client client)
    {
        throw new NotImplementedException();
    }

    public void UpdateCliente(Client client)
    {
        throw new NotImplementedException();
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