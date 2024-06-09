using DTO.CommunicationDTO;

namespace Repository.CommunicationRepository;

public interface IMessageRepository
{
    MessageDTO Get(long Id);
    List<MessageDTO> GetAll();
    void Insert(CreateMessageDTO dto);
    void Update(UpdateMessageDTO dto);
    void Delete(long Id);
}
