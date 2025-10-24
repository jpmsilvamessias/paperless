using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Data.Context;
using ApplicativoTalhonario.models;


namespace ApplicativoTalhonario.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public readonly BaseContext _db;
    
        public ClientRepository(BaseContext baseContext)
        {
            _db = baseContext;
        }

        public void saveClient(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
        }

        public Client findById(int id)
        {
            Client client =
                _db.Clients.Find(id);

            if (client == null)
            {
                return null;
            }
            
            return client;
        }

        public void deleteClient(int id)
        {
            _db.Clients.Remove(_db.Clients.Find(id));
        }
    }
}    

