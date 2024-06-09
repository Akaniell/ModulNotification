using Data.CourseData;
using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Service.CourseService;

public class PracticeService(IPracticeRepository PracticeRepository) : IPracticeService
{ 
    private IPracticeRepository _practiceRepository = PracticeRepository;

    public PracticeDTO GetPractice(long Id)
    {
        return _practiceRepository.Get(Id);
    }
    
    public List<PracticeDTO> GetPractices()
    {
        return _practiceRepository.GetAll();
    }

    public void InsertPractice(CreatePracticeDTO dto)
    {
        _practiceRepository.Insert(dto);
    }

    public void UpdatePractice(UpdatePracticeDTO dto)
    {
        _practiceRepository.Update(dto);
    }

    public void DeletePractice(long id)
    {
        _practiceRepository.Delete(id);
    }
}