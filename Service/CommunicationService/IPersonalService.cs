using Data.CommunicationData;
using DTO.CommunicationDTO;

namespace Service.CommunicationService;

public interface IPersonalService
{
    PersonalDTO GetPersonal(long Id);
    List<PersonalDTO> GetPersonals();
    void InsertPersonal(CreatePersonalDTO dto);
    void UpdatePersonal(UpdatePersonalDTO dto);
    void DeletePersonal(long Id);
}
