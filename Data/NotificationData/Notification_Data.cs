using System.ComponentModel.DataAnnotations;
using Data.UserData;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class Notification_Data
{
    public long Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public DateTime DispatchDateTime { get; set; }
    public long NotificationContentId { get; set; }
    public NotificationContent NotificationContent { get; set; }
    [MaxLength(2000)]
    public string AdditionalText { get; set; }
}

public class Notification_DataMap
{
    public Notification_DataMap(EntityTypeBuilder<Notification_Data> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.UserId).IsRequired();
        entityTypeBuilder.Property(e => e.DispatchDateTime).IsRequired();
        entityTypeBuilder.Property(e => e.NotificationContentId).IsRequired();
        entityTypeBuilder.Property(e => e.AdditionalText).IsRequired(false);
        entityTypeBuilder.HasOne(e => e.NotificationContent)
            .WithMany(e=>e.NotificationDataList)
            .HasForeignKey(e => e.NotificationContentId);
        entityTypeBuilder.HasOne(e => e.User)
            .WithMany(e=>e.NotificationDataList)
            .HasForeignKey(e => e.UserId);
        
    }
}