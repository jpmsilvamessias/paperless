namespace ApplicativoTalhonario.Bussines.Dtos;

public class OffenderDto
{
    public String name {get;set;}
    
    public String cpf {get;set;}
    
    public String address {get;set;}
    
   // 1 offender pode ter 1 ou mais talhonarios public virtual List<T>
}