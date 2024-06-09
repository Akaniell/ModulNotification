using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Service.CourseService;

public class TheoryService(ITheoryRepository TheoryRepository) : ITheoryService
{
    private ITheoryRepository _theoryRepository = TheoryRepository;

    public TheoryDTO GetTheory(long id)
    {
        return _theoryRepository.Get(id);
    }

    public List<TheoryDTO> GetTheories()
    {
        return _theoryRepository.GetAll();
    }

    public void InsertTheory(CreateTheoryDTO dto)
    {
        _theoryRepository.Insert(dto);
    }

    public void UpdateTheory(UpdateTheoryDTO dto)
    {
        _theoryRepository.Update(dto);
    }

    public void DeleteTheory(long id)
    {
        _theoryRepository.Delete(id);
    }
}