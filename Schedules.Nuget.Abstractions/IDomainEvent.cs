namespace Schedules.Nuget.Abstractions;

public interface IDomainEvent
{
    public Guid Id { get; init; }
    public DateTime OccurredOnUtc { get; init; }
}
