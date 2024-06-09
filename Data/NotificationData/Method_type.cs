using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class Method_type
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<Method> MethodList { get; set; } = [];
}

public class Method_TypeMap
{
    public Method_TypeMap(EntityTypeBuilder<Method_type> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Name).IsRequired();
        entityTypeBuilder                       
            .HasMany(e => e.MethodList) 
            .WithOne(e => e.Method_type); 
    }
}