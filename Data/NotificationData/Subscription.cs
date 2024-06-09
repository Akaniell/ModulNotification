using Data.UserData;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class Subscription
{
    public long Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; } 
    public long TypeId { get; set; }
    public Notification_type Notification_type { get; set; } 
    public byte Status { get; set; }
}

public class SubscriptionMap
{
    public SubscriptionMap(EntityTypeBuilder<Subscription> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.UserId).IsRequired();
        entityTypeBuilder.Property(e => e.TypeId).IsRequired();
        entityTypeBuilder.Property(e => e.Status).IsRequired();
        entityTypeBuilder.HasOne(e => e.Notification_type)
            .WithMany(e=>e.SubscriptionList)
            .HasForeignKey(e => e.TypeId);
        entityTypeBuilder.HasOne(e => e.User)
            .WithMany(e=>e.SubscriptionList)
            .HasForeignKey(e => e.UserId);
    }
}