using Data.CommunicationData;
using DTO.CommunicationDTO;

namespace Service.CommunicationService;

public interface IMessageService
{
    MessageDTO GetMessage(long Id);
    List<MessageDTO> GetMessages();
    void InsertMessage(CreateMessageDTO dto);
    void UpdateMessage(UpdateMessageDTO dto);
    void DeleteMessage(long Id);
}
