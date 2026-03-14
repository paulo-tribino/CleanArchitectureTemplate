using Microsoft.AspNetCore.Http;

namespace Presentation.Extensions;

public static class ResultExtensions
{
    public static IResult CancelledRequest()
    {
        return Results.StatusCode(499);
    }
}
