using Data.CommunicationData;
using DTO.CommunicationDTO;
using Repository.CommunicationRepository;

namespace Service.CommunicationService;

public class PersonalService(IPersonalRepository PersonalRepository) : IPersonalService
{
    private IPersonalRepository _personalRepository = PersonalRepository;

    public PersonalDTO GetPersonal(long Id)
    {
        return _personalRepository.Get(Id);
    }

    public List<PersonalDTO> GetPersonals()
    {
        return _personalRepository.GetAll();
    }

    public void InsertPersonal(CreatePersonalDTO dto)
    {
        _personalRepository.Insert(dto);
    }

    public void UpdatePersonal(UpdatePersonalDTO dto)
    {
        _personalRepository.Update(dto);
    }

    public void DeletePersonal(long id)
    {
        _personalRepository.Delete(id);
    }
}
