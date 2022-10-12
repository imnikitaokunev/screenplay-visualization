namespace ScreenplayVisualization.Domain.Entities;

public sealed class Line
{
    public Guid Id { get; set; }
    public string Speaker { get; set; }
    public string Text { get; set; }
    public Guid SectionId { get; set; }
}