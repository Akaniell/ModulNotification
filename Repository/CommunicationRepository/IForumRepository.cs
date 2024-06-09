using DTO.CommunicationDTO;

namespace Repository.CommunicationRepository;

public interface IForumRepository
{
    ForumDTO Get(long Id);
    List<ForumDTO> GetAll();
    void Insert(CreateForumDTO dto);
    void Update(UpdateForumDTO dto);
    void Delete(long Id);
}