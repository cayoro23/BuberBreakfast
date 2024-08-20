namespace BuberBreakfast.Models;

public class Breakfasts
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDatetime { get; }
    public List<string> Savory { get; }
    public List<string> Sweet { get; }

    public Breakfasts(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModifiedDatetime,
        List<string> savory,
        List<string> sweet)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDatetime = lastModifiedDatetime;
        Savory = savory;
        Sweet = sweet;
    }
}
