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
        throw new NotImplementedException();
    }

    public void findOffenderId(int offenderId)
    {
        throw new NotImplementedException();
    }

    public void DeleteOffender(int offenderId)
    {
        throw new NotImplementedException();
    }
}

