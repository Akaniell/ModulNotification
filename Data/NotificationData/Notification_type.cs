using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class Notification_type
{
    public long Id { get; set; }
    public string Name { get; set; }

    public byte Mandatory { get; set; }
    public List<NotificationContent> ContentList { get; set; } = [];
    public List<Subscription> SubscriptionList { get; set; } = [];
}

public class Notification_typeMap
{
    public Notification_typeMap(EntityTypeBuilder<Notification_type> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Name).IsRequired();
        entityTypeBuilder.Property(e => e.Mandatory).IsRequired();
        entityTypeBuilder
            .HasMany(e => e.ContentList)
            .WithOne(e => e.Notification_type);
        entityTypeBuilder
            .HasMany(e => e.SubscriptionList)
            .WithOne(e => e.Notification_type);  
    }
}