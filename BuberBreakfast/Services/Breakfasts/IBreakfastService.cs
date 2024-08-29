using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfasts);
    ErrorOr<Deleted> DeleteBreakfast(Guid id);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertBreakfast> UpsertBreakfast(Breakfast breakfast);
}
