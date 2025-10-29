using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Services;

public class OffenderService : IOfferderService
{
    private readonly IOffenderRepository repository;


    public OffenderService(IOffenderRepository repository)
    {
        this.repository = repository;
    }


    public void saveOffender(OffenderDto offender)
    {
        if (offender == null)
        {
            throw new NullReferenceException("O Infrator está vazio!");
        }
        
        Offender newOffender = new Offender();
        newOffender.id = offender.id;
        newOffender.name = offender.name;
        newOffender.address = offender.address;
        repository.saveOffender(newOffender);
    }

    public Offender findOffenderId(long offenderId)
    {
        Offender offender = repository.findById(offenderId);
        
        if (offender == null)
        {
            throw new Exception ("Offender no encontrado");
        }
        return offender;
    }

    public void DeleteOffender(long offenderId)
    {
        repository.deleteOffender(offenderId);
    }
}

