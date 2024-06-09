using DTO.CommunicationDTO;
using Data.CommunicationData;
using Repository.CommunicationRepository;

namespace Service.CommunicationService;

public class MessageService(IMessageRepository MessageRepository) : IMessageService
{
    private IMessageRepository _messageRepository = MessageRepository;

    public MessageDTO GetMessage(long Id)
    {
        return _messageRepository.Get(Id);
    }

    public List<MessageDTO> GetMessages()
    {
        return _messageRepository.GetAll();
    }

    public void InsertMessage(CreateMessageDTO dto)
    {
        _messageRepository.Insert(dto);
    }

    public void UpdateMessage(UpdateMessageDTO dto)
    {
        _messageRepository.Update(dto);
    }

    public void DeleteMessage(long id)
    {
        _messageRepository.Delete(id);
    }
}
