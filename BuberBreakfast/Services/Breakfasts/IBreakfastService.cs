using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfasts);
    void DeleteBreakfast(Guid id);
    Breakfast GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
}
