
using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using ApplicativoTalhonario.models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicativoTalhonario.Controllers;
[ApiController]
[Route("[controller]")]
public class OffenderControler : ControllerBase
{
    private IOfferderService offenderService;

    public OffenderControler(IOfferderService offenderService)
    {
        this.offenderService = offenderService;
    }

    [HttpGet("GetOffender")]
    public IActionResult GetOffender(long id)
    {
        Offender offender = offenderService.findOffenderId(id);
        return Ok(offender);
    }

    [HttpPost("CreateOffender")]
    public IActionResult CreateOffender([FromBody] OffenderDto newoffender)
    {
        offenderService.saveOffender(newoffender);
        return Ok();
    }

    [HttpPut("UpdateOffender")]
    public IActionResult UpdateOffender(long id, [FromBody] OffenderDto offender)
    {
        if (offenderService.findOffenderId(id) == null)
        {
            return NotFound();
        }
        offenderService.saveOffender(offender);
        return Ok();
    }

    [HttpDelete("DeleteOffender")]
    public IActionResult DeleteOffender(long id)
    {
        offenderService.DeleteOffender(id);
        return Ok();
    }
}