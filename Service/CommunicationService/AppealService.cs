using DTO.CommunicationDTO;
using Data.CommunicationData;
using Repository.CommunicationRepository;
using Repository.CourseRepository;
using Service.CourseService;
using DTO.CourseDTO;

namespace Service.CommunicationService;

public class AppealService(IAppealRepository AppealRepository) : IAppealService
{
    private IAppealRepository _appealRepository = AppealRepository;

    public AppealDTO GetAppeal(long Id)
    {
        return _appealRepository.Get(Id);
    }

    public List<AppealDTO> GetAppeals()
    {
        return _appealRepository.GetAll();
    }

    public void InsertAppeal(CreateAppealDTO dto)
    {
        _appealRepository.Insert(dto);
    }

    public void UpdateAppeal(UpdateAppealDTO dto)
    {
        _appealRepository.Update(dto);
    }

    public void DeleteAppeal(long id)
    {
        _appealRepository.Delete(id);
    }
}
