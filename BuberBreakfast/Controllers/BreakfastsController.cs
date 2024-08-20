using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class BreakfastsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfasts(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDatetime,
            breakfast.Savory,
            breakfast.Sweet);

        return CreatedAtAction(
            actionName: nameof(GetBreakfasts),
            routeValues: new { id = breakfast.Id },
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfasts(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfasts(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfasts(Guid id)
    {
        return Ok(id);
    }
}
