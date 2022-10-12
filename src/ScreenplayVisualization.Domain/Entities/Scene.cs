namespace ScreenplayVisualization.Domain.Entities;

public sealed class Scene
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Section> Sections { get; set; }
}