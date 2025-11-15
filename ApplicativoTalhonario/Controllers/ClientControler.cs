using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using ApplicativoTalhonario.models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicativoTalhonario.Controllers;
[ApiController]
[Route("[controller]")]
public class ClientControler : ControllerBase
{
    private IClientService clientService;

    public ClientControler(IClientService clientService)
    {
        this.clientService = clientService;
    }

    [HttpGet("GetClient")]
    public IActionResult GetClient(long id)
    {
        Client client = clientService.findClientId(id);
        return Ok(client);
    }

    [HttpPost("CreateClient")]
    public IActionResult createClient([FromBody] ClientDto newclient)
    {
            clientService.saveCliente(newclient);
             return Ok();
    }

    [HttpPut("UpdateClient")]
    public IActionResult UpdateClient(long id, [FromBody] ClientDto client)
    {
        if (clientService.findClientId(id) == null)
        {
            return NotFound();
        }
        clientService.saveCliente(client);
        return Ok();
    }

    [HttpDelete("DeleteClient")]
    public IActionResult DeleteClient(long id)
    {
        clientService.DeleteCliente(id);
        return Ok();
    }
}