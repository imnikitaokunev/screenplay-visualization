using Microsoft.EntityFrameworkCore;
using ScreenplayVisualization.Domain.Entities;

namespace ScreenplayVisualization.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Line> Lines { get; }
    DbSet<Section> Sections { get; }
    DbSet<Scene> Scenes { get; }

    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}