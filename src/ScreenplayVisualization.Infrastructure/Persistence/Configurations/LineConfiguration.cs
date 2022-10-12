using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScreenplayVisualization.Domain.Entities;

namespace ScreenplayVisualization.Infrastructure.Persistence.Configurations;

public sealed class LineConfiguration : IEntityTypeConfiguration<Line>
{
    public void Configure(EntityTypeBuilder<Line> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Speaker).IsRequired();
        builder.Property(x => x.Text).IsRequired();
    }
}