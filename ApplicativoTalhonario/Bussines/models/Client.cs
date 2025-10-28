namespace ApplicativoTalhonario.models;

public class Client
{
    
    public long id{ get; set; }
 
    public String name{get;set;}

    public long password{get;set;}
    
    public List<Butcher> Butchers{get;set;}
}