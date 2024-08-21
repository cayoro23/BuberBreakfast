using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error NotFount => Error.NotFound(
            code: "Breakfast.NotFount",
            description: "Breakdast not fount");
    }
}
