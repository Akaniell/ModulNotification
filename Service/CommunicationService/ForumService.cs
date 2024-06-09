using Data.CommunicationData;
using DTO.CommunicationDTO;
using Repository.CommunicationRepository;
using Repository.CourseRepository;
using Service.CourseService;

namespace Service.CommunicationService;

public class ForumService(IForumRepository ForumRepository) : IForumService
{
     private IForumRepository _forumRepository = ForumRepository;

    public ForumDTO GetForum(long Id)
    {
        return _forumRepository.Get(Id);
    }
    
    public List<ForumDTO> GetForums()
    {
        return _forumRepository.GetAll();
    }

    public void InsertForum(CreateForumDTO dto)
    {
        _forumRepository.Insert(dto);
    }

    public void UpdateForum(UpdateForumDTO dto)
    {
        _forumRepository.Update(dto);
    }

    public void DeleteForum(long id)
    {
        _forumRepository.Delete(id);
    }
}
