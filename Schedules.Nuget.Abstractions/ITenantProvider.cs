namespace Schedules.Nuget.Abstractions;

public interface ITenantProvider
{
    TenantInfo GetCurrentTenantInfo();
}
