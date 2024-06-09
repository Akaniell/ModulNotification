using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.NotificationData;

public class Pattern
{
    public long Id { get; set; }
    public string Name { get; set; }
    [MaxLength(2000)]
    public string Default_text { get; set; }
    public List<NotificationContent> ContentList { get; set; } = [];
}

public class PatternMap
{
    public PatternMap(EntityTypeBuilder<Pattern> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Name).IsRequired();
        entityTypeBuilder.Property(e => e.Default_text).IsRequired(false);
        entityTypeBuilder                       
            .HasMany(e => e.ContentList) 
            .WithOne(e => e.Pattern);
    }
}