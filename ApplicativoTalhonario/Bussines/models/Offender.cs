namespace ApplicativoTalhonario.models;

public class Offender
{
    public long id {get;set;}
    
    public String name {get;set;}
    
    public String cpf {get;set;}
    
    public String address {get;set;}
    
    public List<Butcher> butchers{get;set;}
    
    
}