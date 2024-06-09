using Data.CommunicationData;
using DTO.CommunicationDTO;

namespace Service.CommunicationService;

public interface IAppealService
{
    AppealDTO GetAppeal(long Id);
    List<AppealDTO> GetAppeals();
    void InsertAppeal(CreateAppealDTO dto);
    void UpdateAppeal(UpdateAppealDTO dto);
    void DeleteAppeal(long Id);
}
