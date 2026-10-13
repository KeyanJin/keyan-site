namespace KeyanSite.Models;

public class LifeEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    
    public string BodyMarkdown { get; set; } = string.Empty;
    public DateOnly OccuredOn { get; set; } = new DateOnly();
    public EntryStatus Status { get; set; } = EntryStatus.Draft;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? PublishedAtUtc { get; set; } = null;
}

public enum EntryStatus
{
    Draft = 0,
    Published = 1,
}