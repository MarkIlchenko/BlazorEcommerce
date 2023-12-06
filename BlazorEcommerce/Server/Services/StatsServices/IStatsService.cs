namespace BlazorEcommerce.Server.Services.StatsServices
{
    public interface IStatsService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
