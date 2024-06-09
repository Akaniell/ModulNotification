using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CommunicationData;

public class Forum
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public List<Message> MessageList { get; set; } = [];
    
    public Message Message { get; set; }
}

public class ForumMap
{
    public ForumMap(EntityTypeBuilder<Forum> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Name).IsRequired();
        entityTypeBuilder.Property(e => e.Description).IsRequired();
        
        // Форум и сообщения
        entityTypeBuilder
            .HasMany(e => e.MessageList)
            .WithOne(e => e.Forum)
            .OnDelete(DeleteBehavior.Restrict);
    }
}