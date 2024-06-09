using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;


namespace Data.CommunicationData;

public class Appeal
{
    public long Id { get; set; }
    public long User_id { get; set; }
    public string Problem { get; set; }
    public List<Message> MessageList { get; set; } = [];
    
    public Message Message { get; set; }
}

public class AppealMap
{
    public AppealMap(EntityTypeBuilder<Appeal> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.User_id).IsRequired();
        entityTypeBuilder.Property(e => e.Problem).IsRequired();
    
        // обращение и сообщения
        entityTypeBuilder
            .HasMany(e => e.MessageList)
            .WithOne(e => e.Appeal)
            .OnDelete(DeleteBehavior.Restrict);
    }
}