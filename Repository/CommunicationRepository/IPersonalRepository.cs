using DTO.CommunicationDTO;

namespace Repository.CommunicationRepository;

public interface IPersonalRepository
{
    PersonalDTO Get(long Id);
    List<PersonalDTO> GetAll();
    void Insert(CreatePersonalDTO dto);
    void Update(UpdatePersonalDTO dto);
    void Delete(long Id);
}
