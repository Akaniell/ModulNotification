using DTO.CommunicationDTO;

namespace Repository.CommunicationRepository;

public interface IAppealRepository
{
    AppealDTO Get(long Id);
    List<AppealDTO> GetAll();
    void Insert(CreateAppealDTO dto);
    void Update(UpdateAppealDTO dto);
    void Delete(long Id);
}
