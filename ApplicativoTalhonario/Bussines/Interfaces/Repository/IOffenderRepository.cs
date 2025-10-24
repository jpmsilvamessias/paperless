using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public  interface IOffenderRepository
{
    public void saveOffender(ClientDto client);
    
    public Offender findById(int id);
    
    public void deleteOffender(int id);
}