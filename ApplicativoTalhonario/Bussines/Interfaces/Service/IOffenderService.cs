using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IOfferderService
{
        public void saveOffender(OffenderDto offender);
        
        public Offender findOffenderId (long offenderId);
        
        public void DeleteOffender(long offenderId);
}
