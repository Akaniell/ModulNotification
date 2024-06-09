using DTO.GradeDTO;
using Repository.GradeRepository;

namespace Service.GradeService;

public class TestAnswerService(ITestAnswerRepository testAnswerRepository) : ITestAnswerService
{
    private ITestAnswerRepository _testAnswerRepository = testAnswerRepository;

    public TestAnswerDTO GetTestAnswer(long id)
    {
        return _testAnswerRepository.Get(id);
    }

    public List<TestAnswerDTO> GetTestAnswers()
    {
        return _testAnswerRepository.GetAll();
    }

    public void InsertTestAnswer(CreateTestAnswerDTO dto)
    {
        _testAnswerRepository.Insert(dto);
    }

    public void UpdateTestAnswer(UpdateTestAnswerDTO dto)
    {
        _testAnswerRepository.Update(dto);
    }

    public void DeleteTestAnswer(long id)
    {
        _testAnswerRepository.Delete(id);
    }
}

