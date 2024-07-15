using TimeApi.Functionality;

namespace TimeApi;

public static class TimeApiEndpoints
{
    public static void MapTimeApi(this IEndpointRouteBuilder routeBuilder)
    {
        //TODO: Decide what the root should return
        routeBuilder.MapGet("", requestDelegate: context =>
        {
            context.Response.Redirect("TimeOfDay");

            return Task.CompletedTask;
        });


        var timeOfDayGroup = routeBuilder.MapGroup("TimeOfDay");

        timeOfDayGroup.MapGet("Local", (ILocalTimeOfDay t) => t.GetLocalTimeOfDay())
          .WithOpenApi();

        timeOfDayGroup.MapGet("", requestDelegate: context =>
        {
            context.Response.Redirect(context.Request.Path.Add("/Local"));

            return Task.CompletedTask;
        }).WithOpenApi();

        //routeBuilder.MapGet("/TimeOfDay/Local", (ILocalTimeOfDay t) => t.GetLocalTimeOfDay())
        //    .WithName("GetTimeOfDay.Local")
        //    .WithOpenApi();
    }
}