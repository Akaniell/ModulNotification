using DTO.GradeDTO;

namespace Repository.GradeRepository;

public interface ITestAnswerRepository
{
    TestAnswerDTO Get(long id);
    List<TestAnswerDTO> GetAll();
    void Insert(CreateTestAnswerDTO dto);
    void Update(UpdateTestAnswerDTO dto);
    void Delete(long id);
}