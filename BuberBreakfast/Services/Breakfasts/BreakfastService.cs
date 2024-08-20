using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = [];
    public void CreateBreakfast(Breakfast breakfasts)
    {
        _breakfasts.Add(breakfasts.Id, breakfasts);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}
