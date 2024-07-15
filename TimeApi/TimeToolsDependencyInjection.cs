using TimeApi.Functionality;

namespace TimeApi;

public static class TimeToolsDependencyInjection
{
    public static void AddTimeTools(this IServiceCollection services)
    {
        services.AddSingleton<TimeTools>();
        services.AddSingleton<ILocalTimeOfDay>(s => s.GetRequiredService<TimeTools>()); ;
    }
}