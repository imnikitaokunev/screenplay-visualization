namespace ScreenplayVisualization.Domain.Entities;

public sealed class Section
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid SceneId { get; set; }
    public ICollection<Line> Lines { get; set; }
}