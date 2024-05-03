using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Infrastructure;

namespace Models.Configuration.Contracts;

public class ConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.PersianName).HasMaxLength(100);
    }
}
