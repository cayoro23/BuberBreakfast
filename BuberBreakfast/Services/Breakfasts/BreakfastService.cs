using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = [];

    public ErrorOr<Created> CreateBreakfast(Breakfast breakfasts)
    {
        _breakfasts.Add(breakfasts.Id, breakfasts);

        return Result.Created;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);

        return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if(_breakfasts.TryGetValue(id, out var breakfast)){
            return breakfast;
        }

        return Errors.Breakfast.NotFount;
    }

    public ErrorOr<Updated> UpsertBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;

        return Result.Updated;
    }
}
