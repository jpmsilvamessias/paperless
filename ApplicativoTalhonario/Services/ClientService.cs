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

    public void saveCliente(ClientDto dto)
    {
        Client client = repository.findById(dto.id);

        if (dto == null)
        {
            throw new Exception("cliente esta nullo");
        }

        Client newClient = new Client();
        newClient.id = dto.id;
        newClient.name = dto.name;
        newClient.password = dto.senha;
        
        repository.saveClient(newClient);




    }

    public Client findClientId(long id)
    {
        Client client = repository.findById(id);
        if (client == null)
        {
            throw new Exception("cliente esta nullo");
        }
        return client;
    }

    public void DeleteCliente(long id)
    {
        repository.deleteClient(id);
    }
}