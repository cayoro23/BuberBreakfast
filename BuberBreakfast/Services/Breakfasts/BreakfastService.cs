using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = [];
    public void CreateBreakfast(Breakfast breakfasts)
    {
        _breakfasts.Add(breakfasts.Id, breakfasts);
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
    }
}
