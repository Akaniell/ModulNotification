using DTO.CommunicationDTO;
using Data.CommunicationData;
using Microsoft.EntityFrameworkCore;

namespace Repository.CommunicationRepository;

public class MessageRepository(ApplicationContext context) : IMessageRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Message> _messages = context.Set<Message>();

    public MessageDTO Get(long id)
    {
        var message = _messages.SingleOrDefault(e => e.Id == id);
        if (message == null) return null;

        var MessageDTO = new MessageDTO()
        {
            Id = message.Id,
            Mess_text = message.Mess_text,
            Forum_id = message.Forum_id,
            User_id = message.User_id,
            Personal_id = message.Personal_id,
            Appeal_id = message.Appeal_id
        };
        return MessageDTO;
    }

    public List<MessageDTO> GetAll()
    {
        var messages = _messages.ToList();

        return messages.Select(message => new MessageDTO
        {
            Id = message.Id,
            Mess_text = message.Mess_text,
            Forum_id = message.Forum_id,
            User_id = message.User_id,
            Personal_id = message.Personal_id,
            Appeal_id = message.Appeal_id
        }).ToList();
    }

    public void Insert(CreateMessageDTO dto)
    {
        var message = new Message
        {
            Mess_text = dto.Mess_text,
            Forum_id = dto.Forum_id,
            User_id = dto.User_id,
            Personal_id = dto.Personal_id,
            Appeal_id = dto.Appeal_id
        };

        _messages.Add(message);
        context.SaveChanges();
    }

    public void Update(UpdateMessageDTO dto)
    {
        var message = _messages.SingleOrDefault(e => e.Id == dto.Id);
        if (message == null) return;

        message.Mess_text = dto.Mess_text;
        message.Forum_id = dto.Forum_id;
        message.User_id = dto.User_id;
        message.Personal_id = dto.Personal_id;
        message.Appeal_id = dto.Appeal_id;

        _messages.Update(message);
        context.SaveChanges();
    }

    public void Delete(long id)
    {
        var message = _messages.SingleOrDefault(e => e.Id == id);
        if (message == null) return;

        _messages.Remove(message);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}
