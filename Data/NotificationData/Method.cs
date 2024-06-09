using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.UserData;

namespace Data.NotificationData;

public class Method
{
    public long Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; } 
    public long Method_type_id { get; set; }
    public Method_type Method_type { get; set; }
    [MaxLength(30)]
    public string Sending_Data { get; set; }
}

public class MethodMap
{
    public MethodMap(EntityTypeBuilder<Method> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.UserId).IsRequired();
        entityTypeBuilder.Property(e => e.Method_type_id).IsRequired();
        entityTypeBuilder.Property(e => e.Sending_Data).IsRequired();
        entityTypeBuilder.HasOne(e => e.Method_type)
            .WithMany(e=>e.MethodList)
            .HasForeignKey(e => e.Method_type_id);
        entityTypeBuilder.HasOne(e => e.User)
            .WithMany(e=>e.MethodList)
            .HasForeignKey(e => e.UserId);
    }
}