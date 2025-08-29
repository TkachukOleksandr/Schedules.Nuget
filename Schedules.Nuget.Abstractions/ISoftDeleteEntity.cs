namespace Schedules.Nuget.Abstractions;

public interface ISoftDeleteEntity
{
    public bool IsDeleted { get; set; }
    public DateTime? DeletedOnUtc { get; set; }
}
