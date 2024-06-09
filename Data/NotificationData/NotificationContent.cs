using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class NotificationContent
{
    public long Id { get; set; }
    public long TypeId { get; set; } 
    public Notification_type Notification_type { get; set; } 
    public long PatternId { get; set; }
    public Pattern Pattern { get; set; }
    public List<Notification_Data> NotificationDataList { get; set; } = [];
}

public class NotificationContentMap
{
    public NotificationContentMap(EntityTypeBuilder<NotificationContent> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.TypeId).IsRequired();
        entityTypeBuilder.HasOne(e => e.Notification_type)
            .WithMany(e=>e.ContentList)
            .HasForeignKey(e => e.TypeId);
        entityTypeBuilder.Property(e => e.PatternId).IsRequired();
        entityTypeBuilder.HasOne(e => e.Pattern)
            .WithMany(e=>e.ContentList)
            .HasForeignKey(e => e.PatternId);
        
        entityTypeBuilder                       
            .HasMany(e => e.NotificationDataList) 
            .WithOne(e => e.NotificationContent);
    }
}