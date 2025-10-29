using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Bussines.Interfaces.Repository;

public  interface IOffenderRepository
{
    public void saveOffender(Offender offender);
    
    public Offender findById(long id);
    
    public void deleteOffender(long id);
}