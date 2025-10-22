namespace ApplicativoTalhonario.models;

public class Client
{
    
    public long id{ get; set; }
 
    private String nome{get;set;}

    private long senha{get;set;}

    public Client()
    {
    }

    public Client(long id, string nome, long senha)
    {
        this.id = id;
        this.nome = nome;
        this.senha = senha;
    }
}