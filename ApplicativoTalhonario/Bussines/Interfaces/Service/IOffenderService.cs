using ApplicativoTalhonario.Bussines.Dtos;

namespace ApplicativoTalhonario.Bussines.Interfaces.Service;

public interface IOfferderService
{
        public void saveOffender( OffenderDto offender);
        
        
        public void findOffenderId(int offenderId);
        
        public void DeleteOffender(int offenderId);
}
