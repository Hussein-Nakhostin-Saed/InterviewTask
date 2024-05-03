namespace Models.Configuration;

public class CountryConfiguration : ConfigurationBase<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasMany(x => x.Cities).WithOne().OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

        builder.Property(x => x.Code).HasMaxLength(5);

        base.Configure(builder);
    }
}
