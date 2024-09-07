namespace neighbourly.Core.Neighbourhood.Domain;
public class Neighbourhood
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
