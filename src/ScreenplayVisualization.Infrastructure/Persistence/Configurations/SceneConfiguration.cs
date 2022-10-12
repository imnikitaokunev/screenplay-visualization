using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScreenplayVisualization.Domain.Entities;

namespace ScreenplayVisualization.Infrastructure.Persistence.Configurations;

public sealed class SceneConfiguration : IEntityTypeConfiguration<Scene>
{
    public void Configure(EntityTypeBuilder<Scene> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired();

        builder.HasMany(x => x.Sections).WithOne().HasForeignKey(x => x.SceneId);
    }
}