using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class BreakfastsController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateBreakfasts(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfasts(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfasts(Guid id,UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfasts(Guid id)
    {
        return Ok(id);
    }
}
