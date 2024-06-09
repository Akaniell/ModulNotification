using DTO.GradeDTO;

namespace Service.GradeService;

public interface ITestAnswerService
{
    TestAnswerDTO GetTestAnswer(long id); 
    List<TestAnswerDTO> GetTestAnswers(); 
    void InsertTestAnswer(CreateTestAnswerDTO dto);  
    void UpdateTestAnswer(UpdateTestAnswerDTO dto); 
    void DeleteTestAnswer(long id);
}