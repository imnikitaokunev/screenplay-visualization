namespace ScreenplayVisualization.Application.Models;

public sealed class GetScenesResponse
{
    public IEnumerable<SceneDto> Scenes { get; set; }
}