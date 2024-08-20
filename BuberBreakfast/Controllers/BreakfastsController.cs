using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class BreakfastsController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

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

        _breakfastService.CreateBreakfast(breakfast);

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
        Breakfast breakfast = _breakfastService.GetBreakfast(id);

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDatetime,
            breakfast.Savory,
            breakfast.Sweet);

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfasts(Guid id, UpsertBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            id,
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);

        _breakfastService.UpsertBreakfast(breakfast);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfasts(Guid id)
    {
        _breakfastService.DeleteBreakfast(id);

        return NoContent();
    }
}
