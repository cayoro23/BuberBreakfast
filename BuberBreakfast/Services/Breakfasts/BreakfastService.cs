using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

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

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if(_breakfasts.TryGetValue(id, out var breakfast)){
            return breakfast;
        }

        return Errors.Breakfast.NotFount;
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
    }
}
