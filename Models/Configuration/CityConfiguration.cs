namespace Models.Configuration;

public class CityConfiguration : ConfigurationBase<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.Property(x => x.Code).HasMaxLength(5);

        base.Configure(builder);
    }
}
