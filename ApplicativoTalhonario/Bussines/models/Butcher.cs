using ApplicativoTalhonario.Bussines;

namespace ApplicativoTalhonario.models;

public class Butcher
{
    
    public long id{ get; set; }
    
    public String name{ get; set; }
    
    public String number{ get; set; }
    
    public String agent{ get; set; }
    
    public DateTime dateissue{ get; set; }
    
    public decimal price{ get; set; }
    
    public String archiveurl{ get; set; }
    
    public DateTime dateupload{ get; set; }
    
    public  Status status{ get; set; }
    
    public long clientId{ get; set; }
    public Client Client{ get; set; }
    
    public long offenderId{ get; set; }
    public Offender Offender{ get; set; }
    
}