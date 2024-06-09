using Data.CommunicationData;
using DTO.CommunicationDTO;

namespace Service.CommunicationService;

public interface IForumService
{
    ForumDTO GetForum(long Id);
    List<ForumDTO> GetForums();
    void InsertForum(CreateForumDTO dto);
    void UpdateForum(UpdateForumDTO dto);
    void DeleteForum(long Id);
}