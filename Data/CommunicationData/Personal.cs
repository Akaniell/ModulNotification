using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CommunicationData;

public class Personal
{
    public long Id { get; set; }
    public long User_id { get; set; }
    public bool Read_status { get; set; }
    
    public List<Message> MessageList { get; set; } = [];
    
    public Message Message { get; set; }
}

public class PersonalMap
{
    public PersonalMap(EntityTypeBuilder<Personal> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.User_id).IsRequired();
        entityTypeBuilder.Property(e => e.Read_status).IsRequired();
        
        // Приватный чат и сообщения
        entityTypeBuilder
            .HasMany(e => e.MessageList)
            .WithOne(e => e.Personal)
            .OnDelete(DeleteBehavior.Restrict);
    }
}