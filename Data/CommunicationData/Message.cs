using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CommunicationData;

public class Message
{
    public long Id { get; set; }
    public string Mess_text { get; set; }
    public long Forum_id { get; set; }
    public long User_id { get; set; }
    public long Personal_id { get; set; }
    public long Appeal_id { get; set; }
    
    public Forum Forum { get; set; }
    public Personal Personal { get; set; }
    public Appeal Appeal { get; set; }
}

public class MessageMap
{
    public MessageMap(EntityTypeBuilder<Message> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Mess_text).IsRequired();
        //entityTypeBuilder.Property(e => e.Forum_id).IsRequired();
        entityTypeBuilder.Property(e => e.User_id).IsRequired();
        //entityTypeBuilder.Property(e => e.Personal_id).IsRequired();
        //entityTypeBuilder.Property(e => e.Appeal_id).IsRequired();
        
        // Форум и сообщения
        entityTypeBuilder
            .HasOne(e => e.Forum)
            .WithMany(e => e.MessageList)
            .HasForeignKey(e => e.Forum_id);
        // Приватный чат и сообщения
        entityTypeBuilder
            .HasOne(e => e.Personal)
            .WithMany(e => e.MessageList)
            .HasForeignKey(e => e.Personal_id);
        
        // Обращение и сообщения
        entityTypeBuilder
            .HasOne(e => e.Appeal)
            .WithMany(e => e.MessageList)
            .HasForeignKey(e => e.Appeal_id);
    }
}