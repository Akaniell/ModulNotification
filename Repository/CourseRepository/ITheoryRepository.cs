using DTO.CourseDTO;

namespace Repository.CourseRepository;

public interface ITheoryRepository
{
    TheoryDTO Get(long Id);
    List<TheoryDTO> GetAll();
    void Insert(CreateTheoryDTO dto);
    void Update(UpdateTheoryDTO dto);
    void Delete(long Id);
}