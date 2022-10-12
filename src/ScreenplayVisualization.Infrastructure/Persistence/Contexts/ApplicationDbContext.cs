using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ScreenplayVisualization.Application.Common.Interfaces;
using ScreenplayVisualization.Domain.Entities;

namespace ScreenplayVisualization.Infrastructure.Persistence.Contexts;

public sealed class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Line> Lines { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Scene> Scenes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}